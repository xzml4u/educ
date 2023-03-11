void View(int N){
    int index = 2;
    while (index <= N){
        if (index % 2 == 0) Console.WriteLine(index);
        index++;
    }
}

View(50);