﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClosedXML.Excel
{
    public enum XLShiftDeletedCells { ShiftCellsUp, ShiftCellsLeft }
    public enum XLTransposeOptions { MoveCells, ReplaceCells }
    public interface IXLRange: IXLRangeBase
    {
        /// <summary>
        /// Gets the cell at the specified row and column.
        /// <para>The cell address is relative to the parent range.</para>
        /// </summary>
        /// <param name="row">The cell's row.</param>
        /// <param name="column">The cell's column.</param>
        IXLCell Cell(int row, int column);

        /// <summary>Gets the cell at the specified address.</summary>
        /// <para>The cell address is relative to the parent range.</para>
        /// <param name="cellAddressInRange">The cell address in the parent range.</param>
        IXLCell Cell(string cellAddressInRange);

        /// <summary>
        /// Gets the cell at the specified row and column.
        /// <para>The cell address is relative to the parent range.</para>
        /// </summary>
        /// <param name="row">The cell's row.</param>
        /// <param name="column">The cell's column.</param>
        IXLCell Cell(int row, string column);
        /// <summary>Gets the cell at the specified address.</summary>
        /// <para>The cell address is relative to the parent range.</para>
        /// <param name="cellAddressInRange">The cell address in the parent range.</param>
        IXLCell Cell(IXLAddress cellAddressInRange);

        /// <summary>
        /// Gets the specified column of the range.
        /// </summary>
        /// <param name="column">The range column.</param>
        IXLRangeColumn Column(int column);
        /// <summary>
        /// Gets the specified column of the range.
        /// </summary>
        /// <param name="column">The range column.</param>
        IXLRangeColumn Column(string column);
        /// <summary>
        /// Gets the first column of the range.
        /// </summary>
        IXLRangeColumn FirstColumn();
        /// <summary>
        /// Gets the first column of the range that contains a cell with a value.
        /// </summary>
        IXLRangeColumn FirstColumnUsed();
        /// <summary>
        /// Gets the last column of the range.
        /// </summary>
        IXLRangeColumn LastColumn();
        /// <summary>
        /// Gets the last column of the range that contains a cell with a value.
        /// </summary>
        IXLRangeColumn LastColumnUsed();
        /// <summary>
        /// Gets a collection of all columns in this range.
        /// </summary>
        IXLRangeColumns Columns();
        /// <summary>
        /// Gets a collection of the specified columns in this range.
        /// </summary>
        /// <param name="firstColumn">The first column to return.</param>
        /// <param name="lastColumn">The last column to return.</param>
        IXLRangeColumns Columns(int firstColumn, int lastColumn);
        /// <summary>
        /// Gets a collection of the specified columns in this range.
        /// </summary>
        /// <param name="firstColumn">The first column to return.</param>
        /// <param name="lastColumn">The last column to return.</param>
        IXLRangeColumns Columns(string firstColumn, string lastColumn);
        /// <summary>
        /// Gets a collection of the specified columns in this range, separated by commas.
        /// <para>e.g. Columns("G:H"), Columns("10:11,13:14"), Columns("P:Q,S:T"), Columns("V")</para>
        /// </summary>
        /// <param name="columns">The columns to return.</param>
        IXLRangeColumns Columns(string columns);

        /// <summary>
        /// Gets the first row of the range.
        /// </summary>
        IXLRangeRow FirstRow();
        /// <summary>
        /// Gets the first row of the range that contains a cell with a value.
        /// </summary>
        IXLRangeRow FirstRowUsed();
        /// <summary>
        /// Gets the last row of the range.
        /// </summary>
        IXLRangeRow LastRow();
        /// <summary>
        /// Gets the last row of the range that contains a cell with a value.
        /// </summary>
        IXLRangeRow LastRowUsed();
        /// <summary>
        /// Gets the specified row of the range.
        /// </summary>
        /// <param name="row">The range row.</param>
        IXLRangeRow Row(int row);
        /// <summary>
        /// Gets a collection of all rows in this range.
        /// </summary>
        IXLRangeRows Rows();
        /// <summary>
        /// Gets a collection of the specified rows in this range.
        /// </summary>
        /// <param name="firstRow">The first row to return.</param>
        /// <param name="lastRow">The last row to return.</param>
        /// <returns></returns>
        IXLRangeRows Rows(int firstRow, int lastRow);
        /// <summary>
        /// Gets a collection of the specified rows in this range, separated by commas.
        /// <para>e.g. Rows("4:5"), Rows("7:8,10:11"), Rows("13")</para>
        /// </summary>
        /// <param name="rows">The rows to return.</param>
        IXLRangeRows Rows(string rows);

        /// <summary>
        /// Returns the specified range.
        /// </summary>
        /// <param name="rangeAddress">The range boundaries.</param>
        IXLRange Range(IXLRangeAddress rangeAddress);

        /// <summary>Returns the specified range.</summary>
        /// <para>e.g. Range("A1"), Range("A1:C2")</para>
        /// <param name="rangeAddress">The range boundaries.</param>
        IXLRange Range(string rangeAddress);

        /// <summary>Returns the specified range.</summary>
        /// <param name="firstCell">The first cell in the range.</param>
        /// <param name="lastCell"> The last cell in the range.</param>
        IXLRange Range(IXLCell firstCell, IXLCell lastCell);

        /// <summary>Returns the specified range.</summary>
        /// <param name="firstCellAddress">The first cell address in the range.</param>
        /// <param name="lastCellAddress"> The last cell address in the range.</param>
        IXLRange Range(string firstCellAddress, string lastCellAddress);

        /// <summary>Returns the specified range.</summary>
        /// <param name="firstCellAddress">The first cell address in the range.</param>
        /// <param name="lastCellAddress"> The last cell address in the range.</param>
        IXLRange Range(IXLAddress firstCellAddress, IXLAddress lastCellAddress);

        /// <summary>Returns a collection of ranges, separated by commas.</summary>
        /// <para>e.g. Ranges("A1"), Ranges("A1:C2"), Ranges("A1:B2,D1:D4")</para>
        /// <param name="ranges">The ranges to return.</param>
        IXLRanges Ranges(string ranges);

        /// <summary>Returns the specified range.</summary>
        /// <param name="firstCellRow">   The first cell's row of the range to return.</param>
        /// <param name="firstCellColumn">The first cell's column of the range to return.</param>
        /// <param name="lastCellRow">    The last cell's row of the range to return.</param>
        /// <param name="lastCellColumn"> The last cell's column of the range to return.</param>
        /// <returns>.</returns>
        IXLRange Range(int firstCellRow, int firstCellColumn, int lastCellRow, int lastCellColumn);

        /// <summary>Gets the number of rows in this range.</summary>
        int RowCount();

        /// <summary>Gets the number of columns in this range.</summary>
        int ColumnCount();

        /// <summary>
        /// Inserts X number of columns to the right of this range.
        /// <para>All cells to the right of this range will be shifted X number of columns.</para>
        /// </summary>
        /// <param name="numberOfColumns">Number of columns to insert.</param>
        void InsertColumnsAfter(int numberOfColumns);
        void InsertColumnsAfter(int numberOfColumns, Boolean expandRange);
        /// <summary>
        /// Inserts X number of columns to the left of this range.
        /// <para>This range and all cells to the right of this range will be shifted X number of columns.</para>
        /// </summary>
        /// <param name="numberOfColumns">Number of columns to insert.</param>
        void InsertColumnsBefore(int numberOfColumns);
        void InsertColumnsBefore(int numberOfColumns, Boolean expandRange);
        /// <summary>
        /// Inserts X number of rows on top of this range.
        /// <para>This range and all cells below this range will be shifted X number of rows.</para>
        /// </summary>
        /// <param name="numberOfRows">Number of rows to insert.</param>
        void InsertRowsAbove(int numberOfRows);
        void InsertRowsAbove(int numberOfRows, Boolean expandRange);
        /// <summary>
        /// Inserts X number of rows below this range.
        /// <para>All cells below this range will be shifted X number of rows.</para>
        /// </summary>
        /// <param name="numberOfRows">Number of rows to insert.</param>
        void InsertRowsBelow(int numberOfRows);
        void InsertRowsBelow(int numberOfRows, Boolean expandRange);

        /// <summary>
        /// Deletes this range and shifts the surrounding cells accordingly.
        /// </summary>
        /// <param name="shiftDeleteCells">How to shift the surrounding cells.</param>
        void Delete(XLShiftDeletedCells shiftDeleteCells);

        /// <summary>
        /// Transposes the contents and styles of all cells in this range.
        /// </summary>
        /// <param name="transposeOption">How to handle the surrounding cells when transposing the range.</param>
        void Transpose(XLTransposeOptions transposeOption);

        IXLTable AsTable();
        IXLTable AsTable(String name);
        IXLTable CreateTable();
        IXLTable CreateTable(String name);

        IXLRange RangeUsed();
    }
}
