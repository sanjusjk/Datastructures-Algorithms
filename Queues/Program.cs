/*
 *      Queues are FIFO Data structure. that means the elements inserted first are retrieved first unlike a Stack.
 * 
 *      Queues are Linear Data Structure. 1 by 1
 *     
 *      queues has methods TryPeek and TryDequeue.
 *      
 *      Queues offer methods like Enqueue() and Dequeue() to insert and retrieve respectively
 * 
 *      Queues can also be used with methods of Collections as it implements Icollection interface
 * 
 *       
 *      Uses:
 *      Queues are used in LinkedList, PriorityQueues, Breadth-First Search Algorithms
 *      Keyboard Buffer (order of letter pressed)
 *      Printer Queues
 */

//Examples:


Queue<string> queue = new Queue<string>();

queue.Enqueue("a");
queue.Enqueue("b");
queue.Enqueue("c");
queue.Enqueue("d");

Console.WriteLine(queue.ElementAt(2)+"\n");


while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}

var ss = queue.TryPeek(out string res);
var sss = queue.TryDequeue(out string res1);


Console.WriteLine(ss + "\n");
Console.WriteLine(sss + "\n");