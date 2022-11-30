void FillArray(int [] collection){
    int Length = collection.Length;
    int i = 0;
    while(i<Length){
        collection[i] = new Random().Next(1, 10);
        i++;
        }
}

void PrintAray(int [] col){
    int count = col.Length;
    int position = 0;
    while (position < count){
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int [] collection, int find ){
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index<count){
        if(collection[index] == find){
            position=index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];

FillArray(array);
PrintAray(array);
Console.WriteLine();
int pos = IndexOf(array, -1);
Console.WriteLine(pos);