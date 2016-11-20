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

    public MenuManager(int rows, int columns, int defaultRow, int defaultCol,  Button first){

        buttonExistanceGrid = new int[rows, columns];
        InitializeGrid();
        selectedColumn = defaultCol;
        selectedRow = defaultRow;
        buttonObjectGrid = new Button[rows,columns];

        SetButton(defaultRow, defaultCol, first);
        Select();

        this.rows = rows;
        this.columns = columns;
        
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
        buttonObjectGrid[selectedRow,selectedColumn].gameObject.GetComponentInChildren<Text>().color = new Color(255, 0, 0, 255);
    }
    void Deselect()
    {
        buttonObjectGrid[selectedRow, selectedColumn].gameObject.GetComponentInChildren<Text>().color = new Color(0, 0, 0, 255);
    }

    public void ActivateCurrent()
    {
        //find the action associated with the currently selected menu option
        Debug.Log("Character Setup Selected!");
        buttonObjectGrid[selectedRow, selectedColumn].Invoke("Activate", 0);
        //change to get component IStartCommand

    }
    public void MoveSelectorLeft()
    {
        int newCol = mod((selectedColumn - 1), columns);
        if(buttonExistanceGrid[selectedRow, newCol] == 1)
        {
            Deselect();
            selectedColumn = newCol;
            Select();
        }
    }
    public void MoveSelectorRight()
    {
        int newCol = mod((selectedColumn + 1) , columns);
        if (buttonExistanceGrid[selectedRow, newCol] == 1)
        {
            Deselect();
            selectedColumn = newCol;
            Select();
        }
    }
    public void MoveSelectorUp()
    {
        int newRow = mod((selectedRow - 1) ,rows);
        if (buttonExistanceGrid[newRow, selectedColumn] == 1)
        {
            Deselect();
            selectedRow = newRow;
            Select();
        }
    }
    public void MoveSelectorDown()
    {
        int newRow = mod((selectedRow + 1), rows);
        if (buttonExistanceGrid[newRow, selectedColumn] == 1)
        {
            Deselect();
            selectedRow = newRow;
            Select();
        }
    }
    int mod(int a, int b)
    {
        int r = a % b;
        return r < 0 ? r + b : r;
    }
}

