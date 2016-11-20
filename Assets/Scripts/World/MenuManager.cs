using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuManager{
    int[,] buttonExistanceGrid; //value of 1 means there is a button there, 0 means no button
    Button[,] buttonObjectGrid;
    int selectedRow;
    int selectedColumn;

    int rows;
    int columns;

    public MenuManager(int rows, int columns, int defaultRow, int defaultCol, Button first){
        buttonExistanceGrid = new int[rows, columns];
        selectedColumn = defaultCol;
        selectedRow = defaultRow;

        SetButton(defaultRow, defaultCol, first);

        //gameObject.GetComponentInChildren<Text>().color = new Color(255, 255, 255, 255);

        this.rows = rows;
        this.columns = columns;
        InitializeGrid();
    }

    private void InitializeGrid()
    {
        for(int i=0; i < rows; i++)
        {
            for(int j=0; j < columns; j++)
            {
                buttonExistanceGrid[i, j] = 0;
            }
        }
    }
    public void SetButton(int row, int col, Button button)
    {
        buttonExistanceGrid[row, col] = 1;
        buttonObjectGrid[row, col] = button;
    }
    void Select()
    {
        buttonObjectGrid[selectedRow,selectedColumn].gameObject.GetComponentInChildren<Text>().color = new Color(255, 255, 255, 255);
    }
    void Deselect()
    {
        buttonObjectGrid[selectedRow, selectedColumn].gameObject.GetComponentInChildren<Text>().color = new Color(255, 0, 0, 255);
    }

    public void ActivateCurrent()
    {
        //find the action associated with the currently selected menu option
        buttonObjectGrid[selectedRow, selectedColumn].Invoke("Activate", 0);

    }
    public void MoveSelectorLeft()
    {
        int newCol = (selectedColumn - 1) % columns;
        if(buttonExistanceGrid[selectedRow, newCol] == 1)
        {
            Deselect();
            selectedColumn = newCol;
            Select();
        }
    }
    public void MoveSelectorRight()
    {
        int newCol = (selectedColumn + 1) % columns;
        if (buttonExistanceGrid[selectedRow, newCol] == 1)
        {
            Deselect();
            selectedColumn = newCol;
            Select();
        }
    }
    public void MoveSelectorUp()
    {
        int newRow = (selectedRow - 1) % rows;
        if (buttonExistanceGrid[newRow, selectedColumn] == 1)
        {
            Deselect();
            selectedRow = newRow;
            Select();
        }
    }
    public void MoveSelectorDown()
    {
        int newRow = (selectedRow + 1) % rows;
        if (buttonExistanceGrid[newRow, selectedColumn] == 1)
        {
            Deselect();
            selectedRow = newRow;
            Select();
        }
    }
}

