namespace Exercise
{
    public class ArrayRotation
    {
        public static void rotLeft(int[] a, int d)
        {

            for (int i = 1; i <= d; i++)
            {
                Rotate(a);
            }
            System.Console.WriteLine(string.Join(',', a));

        }
        public static void Rotate(int[] arr)
        {
            int first;

            /* Store first element of array */
            first = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                /* Move each array element to its left */
                arr[i] = arr[i + 1];
            }

            /* Copies the first element of array to last */
            arr[arr.Length - 1] = first;

        }
    }
}