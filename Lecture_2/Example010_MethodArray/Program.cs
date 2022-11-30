int [] array = {11,221,41,4,61,17,18,19,55};

int n = array.Length;
int find = 4;
int index = 0;

while (index < n){
    if (array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;

}