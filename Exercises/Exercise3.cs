namespace P02.Exercises;

public static class PrintTwoDimensionalArray
{
    public static void Run()
    {
        const int numberOfRows = 6;
        const int numberOfColumns = 4;

        char[,] content =
{ //   DNA-sekvens Columns→
    { 'A', 'T', 'C', 'G' }, // | DNA 1
    { 'C', 'G', 'T', 'A' }, // | Rows
    { 'G', 'C', 'A', 'T' }, // |    
    { 'C', 'G', 'T', 'A' }, // |
    { 'G', 'A', 'T', 'C' }, // |
    { 'T', 'A', 'G', 'C' }  // ↓ DNA 6
};

        for (int row = 0; row < numberOfRows; row++)
        {
            for (int column = 0; column < numberOfColumns; column++)
            {
                Console.Write(content[row, column]);
            }

            Console.WriteLine();
        }
    }
}
