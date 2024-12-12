﻿using RestSharp;
using Smartsheet.Api;
using Smartsheet.Api.Models;

namespace integration_test_sdk_net80
{
    [TestClass]
    public class RowResourcesTest
    {
        [TestMethod]
        public void TestRowResources()
        {
            SmartsheetClient smartsheet = new SmartsheetBuilder().SetMaxRetryTimeout(30000).Build();

            var templateDataId = smartsheet.TemplateResources.ListPublicTemplates().Data[0].Id;
            Assert.IsNotNull(templateDataId);
            long templateId = templateDataId.Value;
            long sheetId = CreateSheetFromTemplate(smartsheet, templateId);

            PaginatedResult<Column> columnsResult = smartsheet.SheetResources.ColumnResources.ListColumns(sheetId);
            var columnDataId = columnsResult.Data[0].Id;
            Assert.IsNotNull(columnDataId);
            long columnId = columnDataId.Value;

            Cell[] cellsToAdd = new Cell[] { new Cell.AddCellBuilder(columnId, true).SetValue("hello").SetStrict(false).Build() };

            long rowId = AddRows(smartsheet, sheetId, columnId, cellsToAdd);
            AddRowsWithPartialSuccess(smartsheet, sheetId, cellsToAdd);

            CopyRowToCreatedSheet(smartsheet, sheetId, rowId);

            SendRows(smartsheet, sheetId, columnId, rowId);

            DeleteRowAndGetRow(smartsheet, sheetId, rowId);

            smartsheet.SheetResources.DeleteSheet(sheetId);
        }

        private static void SendRows(SmartsheetClient smartsheet, long sheetId, long columnId, long rowId)
        {
            MultiRowEmail multiRowEmail = new MultiRowEmail
            {
                SendTo = new Recipient[] { new Recipient { Email = "ericyan99@outlook.com" } },
                Subject = "some subject",
                Message = "some message",
                CcMe = false,
                RowIds = new long[] { rowId },
                ColumnIds = new long[] { columnId },
                IncludeAttachments = false,
                IncludeDiscussions = false
            };

            smartsheet.SheetResources.RowResources.SendRows(sheetId, multiRowEmail);
        }

        private static void DeleteRowAndGetRow(SmartsheetClient smartsheet, long sheetId, long rowId)
        {

            smartsheet.SheetResources.RowResources.DeleteRows(sheetId, new long[] { rowId }, false);
            try
            {
                smartsheet.SheetResources.RowResources.GetRow(sheetId, rowId, new RowInclusion[] { RowInclusion.COLUMNS });
                Assert.Fail("Cannot get a deleted row.");

                smartsheet.SheetResources.RowResources.GetRow(sheetId, rowId);
                Assert.Fail("Cannot get a deleted row.");
            }
            catch
            {
                //Not found.
            }
        }

        private static void CopyRowToCreatedSheet(SmartsheetClient smartsheet, long sheetId, long rowId)
        {
            var tempSheet = smartsheet.SheetResources.CreateSheet(new Sheet.CreateSheetBuilder("tempSheet", new Column[] { new Column.CreateSheetColumnBuilder("col1", true, ColumnType.TEXT_NUMBER).Build() }).Build()).Id;
            Assert.IsNotNull(tempSheet);
            long tempSheetId = tempSheet.Value;
            CopyOrMoveRowDestination destination = new CopyOrMoveRowDestination { SheetId = tempSheetId };
            CopyOrMoveRowDirective directive = new CopyOrMoveRowDirective { RowIds = new long[] { rowId }, To = destination };
            CopyOrMoveRowResult result = smartsheet.SheetResources.RowResources.CopyRowsToAnotherSheet(sheetId, directive, new CopyRowInclusion[] { CopyRowInclusion.CHILDREN }, false);
            smartsheet.SheetResources.DeleteSheet(tempSheetId);
        }

        private static long AddRows(SmartsheetClient smartsheet, long sheetId, long columnId, Cell[] cellsToAdd)
        {
            Row row = new Row.AddRowBuilder(true, null, null, null, null).SetCells(cellsToAdd).Build();
            IList<Row> rows = smartsheet.SheetResources.RowResources.AddRows(sheetId, new Row[] { row });
            Assert.IsTrue(rows.Count == 1);
            var rowsId = rows[0].Id;
            Assert.IsNotNull(rowsId);
            long rowId = rowsId.Value;
            bool foundValue = false;
            foreach (Cell cell in rows[0].Cells)
            {
                if (cell.ColumnId == columnId)
                {
                    Assert.IsTrue(cell.Value.ToString() == "hello");
                    foundValue = true;
                    break;
                }
            }
            Assert.IsTrue(foundValue);
            return rowId;
        }

        private static void AddRowsWithPartialSuccess(SmartsheetClient smartsheet, long sheetId, Cell[] cellsToAdd)
        {
            Row row0 = new Row.AddRowBuilder(true, null, null, null, null).SetCells(cellsToAdd).Build();
            Row row1 = new Row.AddRowBuilder(true, null, null, null, null).SetCells(cellsToAdd).Build();
            BulkItemRowResult rows = smartsheet.SheetResources.RowResources.AddRowsAllowPartialSuccess(sheetId, new Row[] { row0, row1 });
            Assert.IsTrue(rows.Result.Count == 2);
        }

        private static long CreateSheetFromTemplate(SmartsheetClient smartsheet, long templateId)
        {
            // Create a new sheet off of that template.
            Sheet newSheet = smartsheet.SheetResources.CreateSheetFromTemplate(new Sheet.CreateSheetFromTemplateBuilder("New Sheet", templateId).Build(), new TemplateInclusion[] { TemplateInclusion.DATA, TemplateInclusion.RULE_RECIPIENTS, TemplateInclusion.RULES });
            var newSheetId = newSheet.Id;
            Assert.IsNotNull(newSheetId);
            return newSheetId.Value;
        }
    }
}