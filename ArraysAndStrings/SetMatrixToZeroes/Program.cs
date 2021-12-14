// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var aox = new int[][] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
SetZeroes(aox);


static void SetZeroes(int[][] matrix)
{
    var columns = matrix[0].Length;
    var rows = matrix.Length;

    var columnsToZero = new List<int>();
    var rowsToZero = new List<int>();


    for (int i = 0; i < matrix.Length; i++)
    {
        for(int columnIndex = 0; columnIndex < matrix[i].Length; columnIndex++)
        {
            if(matrix[i][columnIndex] == 0)
            {
                rowsToZero.Add(i);
                columnsToZero.Add(columnIndex);
            }
        }
    }

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int columnIndex = 0; columnIndex < matrix[i].Length; columnIndex++)
        {
            if (columnsToZero.Contains(columnIndex) || rowsToZero.Contains(i))
                matrix[i][columnIndex] = 0;
        } 
    }
}