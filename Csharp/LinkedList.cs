using System;

namespace Csharp
{
// See https://aka.ms/new-console-template for more information
//linked list with heap
// list loc:  data: next loc:
//priority
class Linkedlist {
    public int?[] heap;
    public int noOfitems;
    public Object?[,] dataNmemoryloc;
    public int? Headloc;
    public Random rab = new Random();
    public Linkedlist(int num) {
        heap = new int?[num];
        dataNmemoryloc = new Object?[num,3];
            for (int i = 0; i < num; i++)
            {
                dataNmemoryloc[i, 0] = "";
                noOfitems = 0;
                heap[i] = i;
            }
    }
    void AddHead(Exception overflowException, string data)
    {
        int newloc = AddValue(data);
        if (Headloc == null)
        {
            Headloc = newloc;
            dataNmemoryloc[newloc, 1] = null;
        }
        else
        {
            int temp = (int)Headloc;
            Headloc = newloc;
            dataNmemoryloc[newloc, 1] = Headloc;
        }
    }
    int? GetNextBlockloc(int num)
    {
        return (int?)dataNmemoryloc[num, 1];
    }
    string? GetBlockData(int num)
    {
        return (string?)dataNmemoryloc[num, 0];
    }
    void AddFoot(string data)
    {
        int newloc = AddValue(data);
        int count = 0;
        while (true) { if (dataNmemoryloc[count, 1] == null) break; else count++;  }
        int temp = count;
        dataNmemoryloc[count, 1] = newloc;
        dataNmemoryloc[newloc, 1] = null;
    }
    int? Searchdata(string datatofind, int loc,bool firstTime) //use base case control recursion but one return needed?
    {   if (firstTime) { loc = (int)Headloc; firstTime = false; }
        if (dataNmemoryloc[loc, 0] != datatofind)
        {
            loc = (int)dataNmemoryloc[loc, 1];
            Searchdata(datatofind, loc, firstTime);
            return null;
        }
        else
        {
            return loc;
        }
    }
    int? SearchPriority(int priority, int loc = -1, bool firstTime= true)
    {
        if(firstTime) { loc = (int)Headloc; firstTime = false; }
        if(priority <= (int)dataNmemoryloc[loc, 2])
        {//repeat
            loc = (int)dataNmemoryloc[loc, 1];
            SearchPriority(priority, loc, firstTime);
            return null;
        }
        else
        {
            return loc++;
        }
    }
    void AddMiddle(string inputdata, int priority)
    {
        int temp = (int)dataNmemoryloc[(int)SearchPriority(priority), 1];        
        int newloc = AddValue(inputdata, priority);
        dataNmemoryloc[temp, 1] = newloc;
        dataNmemoryloc[newloc, 1] = temp;
    }
    int AddValue(string data, int priority = 5)
    {
        int newloc = rab.Next(heap.Length);
        dataNmemoryloc[newloc, 0] = data;
        dataNmemoryloc[newloc, 2] = priority;
        heap[newloc] = null;
        return newloc;
    }
}

}