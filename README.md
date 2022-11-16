# 11troider-random

Skip to main content

We use optional cookies to improve your experience on our websites, such as through social media connections, and to display personalized advertising based on your online activity. If you reject optional cookies, only cookies necessary to provide you the services will be used. You may change your selection by clicking “Manage Cookies” at the bottom of the page. Privacy Statement Third-Party Cookies

Sign in

Version
Search

    System

Action
Action<T>
Action<T1,T2>
Action<T1,T2,T3>
Action<T1,T2,T3,T4>
Action<T1,T2,T3,T4,T5>
Action<T1,T2,T3,T4,T5,T6>
Action<T1,T2,T3,T4,T5,T6,T7>
Action<T1,T2,T3,T4,T5,T6,T7,T8>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>
AssemblyLoadEventHandler
AsyncCallback
AttributeTargets
Base64FormattingOptions
Comparison<T>
ConsoleCancelEventHandler
ConsoleColor
ConsoleKey
ConsoleModifiers
ConsoleSpecialKey
Converter<TInput,TOutput>
DateTimeKind
DayOfWeek
Environment.SpecialFolder
Environment.SpecialFolderOption
EnvironmentVariableTarget
EventHandler
EventHandler<TEventArgs>
Func<TResult>
Func<T,TResult>
Func<T1,T2,TResult>
Func<T1,T2,T3,TResult>
Func<T1,T2,T3,T4,TResult>
Func<T1,T2,T3,T4,T5,TResult>
Func<T1,T2,T3,T4,T5,T6,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,TResult>
GCCollectionMode
GCKind
GCNotificationStatus
GenericUriParserOptions
LoaderOptimization
MidpointRounding
PlatformID
Predicate<T>
Random
Constructors
ResolveEventHandler
RuntimeArgumentHandle
StringComparison
StringSplitOptions
TypeCode
UnhandledExceptionEventHandler
UriComponents
UriFormat
UriHostNameType
UriKind
UriPartial
Void

    Learn .NET .NET API browser System 

Random Class

    Reference

Definition

Namespace:
    System 

Assembly:
    System.Runtime.dll

Represents a pseudo-random number generator, which is an algorithm that produces a sequence of numbers that meet certain statistical requirements for randomness.
C#

public class Random

Inheritance
    Object
    Random

Examples

The following example creates a single random number generator and calls its NextBytes, Next, and NextDouble methods to generate sequences of random numbers within different ranges.
C#

// Instantiate random number generator using system-supplied value as seed.
var rand = new Random();

// Generate and display 5 random byte (integer) values.
var bytes = new byte[5];
rand.NextBytes(bytes);
Console.WriteLine("Five random byte values:");
foreach (byte byteValue in bytes)
    Console.Write("{0, 5}", byteValue);
Console.WriteLine();

// Generate and display 5 random integers.
Console.WriteLine("Five random integer values:");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,15:N0}", rand.Next());
Console.WriteLine();

// Generate and display 5 random integers between 0 and 100.
Console.WriteLine("Five random integers between 0 and 100:");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,8:N0}", rand.Next(101));
Console.WriteLine();

// Generate and display 5 random integers from 50 to 100.
Console.WriteLine("Five random integers between 50 and 100:");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,8:N0}", rand.Next(50, 101));
Console.WriteLine();

// Generate and display 5 random floating point values from 0 to 1.
Console.WriteLine("Five Doubles.");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,8:N3}", rand.NextDouble());
Console.WriteLine();

// Generate and display 5 random floating point values from 0 to 5.
Console.WriteLine("Five Doubles between 0 and 5.");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,8:N3}", rand.NextDouble() * 5);

// The example displays output like the following:
//    Five random byte values:
//      194  185  239   54  116
//    Five random integer values:
//        507,353,531  1,509,532,693  2,125,074,958  1,409,512,757    652,767,128
//    Five random integers between 0 and 100:
//          16      78      94      79      52
//    Five random integers between 50 and 100:
//          56      66      96      60      65
//    Five Doubles.
//       0.943   0.108   0.744   0.563   0.415
//    Five Doubles between 0 and 5.
//       2.934   3.130   0.292   1.432   4.369

The following example generates a random integer that it uses as an index to retrieve a string value from an array.
C#

Random rnd = new Random();
string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
string[] femalePetNames = { "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla" };

// Generate random indexes for pet names.
int mIndex = rnd.Next(malePetNames.Length);
int fIndex = rnd.Next(femalePetNames.Length);

// Display the result.
Console.WriteLine("Suggested pet name of the day: ");
Console.WriteLine("   For a male:     {0}", malePetNames[mIndex]);
Console.WriteLine("   For a female:   {0}", femalePetNames[fIndex]);

// The example displays output similar to the following:
//       Suggested pet name of the day:
//          For a male:     Koani
//          For a female:   Maggie

Remarks

Pseudo-random numbers are chosen with equal probability from a finite set of numbers. The chosen numbers are not completely random because a mathematical algorithm is used to select them, but they are sufficiently random for practical purposes. The current implementation of the Random class is based on a modified version of Donald E. Knuth's subtractive random number generator algorithm. For more information, see D. E. Knuth. The Art of Computer Programming, Volume 2: Seminumerical Algorithms. Addison-Wesley, Reading, MA, third edition, 1997.

To generate a cryptographically secure random number, such as one that's suitable for creating a random password, use the RNGCryptoServiceProvider class or derive a class from System.Security.Cryptography.RandomNumberGenerator.

In this topic:

Instantiating the random number generator
Avoiding multiple instantiations
The System.Random class and thread safety
Generating different types of random numbers
Substituting your own algorithm
How do you use System.Random to…
Retrieve the same sequence of random values
Retrieve unique sequences of random values
Retrieve integers in a specified range
Retrieve integers with a specified number of digits
Retrieve floating-point values in a specified range
Generate random Boolean values
Generate random 64-bit integers
Retrieve bytes in a specified range
Retrieve an element from an array or collection at random
Retrieve a unique element from an array or collection

Instantiating the random number generator

You instantiate the random number generator by providing a seed value (a starting value for the pseudo-random number generation algorithm) to a Random class constructor. You can supply the seed value either explicitly or implicitly:

    The Random(Int32) constructor uses an explicit seed value that you supply.

    The Random() constructor uses the default seed value. This is the most common way of instantiating the random number generator.

In .NET Framework, the default seed value is time-dependent. In .NET Core, the default seed value is produced by the thread-static, pseudo-random number generator.

If the same seed is used for separate Random objects, they will generate the same series of random numbers. This can be useful for creating a test suite that processes random values, or for replaying games that derive their data from random numbers. However, note that Random objects in processes running under different versions of the .NET Framework may return different series of random numbers even if they're instantiated with identical seed values.

To produce different sequences of random numbers, you can make the seed value time-dependent, thereby producing a different series with each new instance of Random. The parameterized Random(Int32) constructor can take an Int32 value based on the number of ticks in the current time, whereas the parameterless Random() constructor uses the system clock to generate its seed value. However, on the .NET Framework only, because the clock has finite resolution, using the parameterless constructor to create different Random objects in close succession creates random number generators that produce identical sequences of random numbers. The following example illustrates how two Random objects that are instantiated in close succession in a .NET Framework application generate an identical series of random numbers. On most Windows systems, Random objects created within 15 milliseconds of one another are likely to have identical seed values.
C#

byte[] bytes1 = new byte[100];
byte[] bytes2 = new byte[100];
Random rnd1 = new Random();
Random rnd2 = new Random();

rnd1.NextBytes(bytes1);
rnd2.NextBytes(bytes2);

Console.WriteLine("First Series:");
for (int ctr = bytes1.GetLowerBound(0);
     ctr <= bytes1.GetUpperBound(0);
     ctr++) {
   Console.Write("{0, 5}", bytes1[ctr]);
   if ((ctr + 1) % 10 == 0) Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Second Series:");
for (int ctr = bytes2.GetLowerBound(0);
     ctr <= bytes2.GetUpperBound(0);
     ctr++) {
   Console.Write("{0, 5}", bytes2[ctr]);
   if ((ctr + 1) % 10 == 0) Console.WriteLine();
}

// The example displays output like the following:
//       First Series:
//          97  129  149   54   22  208  120  105   68  177
//         113  214   30  172   74  218  116  230   89   18
//          12  112  130  105  116  180  190  200  187  120
//           7  198  233  158   58   51   50  170   98   23
//          21    1  113   74  146  245   34  255   96   24
//         232  255   23    9  167  240  255   44  194   98
//          18  175  173  204  169  171  236  127  114   23
//         167  202  132   65  253   11  254   56  214  127
//         145  191  104  163  143    7  174  224  247   73
//          52    6  231  255    5  101   83  165  160  231
//
//       Second Series:
//          97  129  149   54   22  208  120  105   68  177
//         113  214   30  172   74  218  116  230   89   18
//          12  112  130  105  116  180  190  200  187  120
//           7  198  233  158   58   51   50  170   98   23
//          21    1  113   74  146  245   34  255   96   24
//         232  255   23    9  167  240  255   44  194   98
//          18  175  173  204  169  171  236  127  114   23
//         167  202  132   65  253   11  254   56  214  127
//         145  191  104  163  143    7  174  224  247   73
//          52    6  231  255    5  101   83  165  160  231

To avoid this problem, create a single Random object instead of multiple objects. Note that the Random class in .NET Core does not have this limitation.

Avoiding multiple instantiations

On the .NET Framework, initializing two random number generators in a tight loop or in rapid succession creates two random number generators that can produce identical sequences of random numbers. In most cases, this is not the developer's intent and can lead to performance issues, because instantiating and initializing a random number generator is a relatively expensive process.

Both to improve performance and to avoid inadvertently creating separate random number generators that generate identical numeric sequences, we recommend that you create one Random object to generate many random numbers over time, instead of creating new Random objects to generate one random number.

However, the Random class isn't thread safe. If you call Random methods from multiple threads, follow the guidelines discussed in the next section.

The System.Random class and thread safety

Instead of instantiating individual Random objects, we recommend that you create a single Random instance to generate all the random numbers needed by your app. However, Random objects are not thread safe. If your app calls Random methods from multiple threads, you must use a synchronization object to ensure that only one thread can access the random number generator at a time. If you don't ensure that the Random object is accessed in a thread-safe way, calls to methods that return random numbers return 0.

The following example uses the C# lock Statement, the F# lock function and the Visual Basic SyncLock statement to ensure that a single random number generator is accessed by 11 threads in a thread-safe manner. Each thread generates 2 million random numbers, counts the number of random numbers generated and calculates their sum, and then updates the totals for all threads when it finishes executing.
C#

using System;
using System.Threading;

public class Example
{
   [ThreadStatic] static double previous = 0.0;
   [ThreadStatic] static int perThreadCtr = 0;
   [ThreadStatic] static double perThreadTotal = 0.0;
   static CancellationTokenSource source;
   static CountdownEvent countdown;
   static Object randLock, numericLock;
   static Random rand;
   double totalValue = 0.0;
   int totalCount = 0;

   public Example()
   {
      rand = new Random();
      randLock = new Object();
      numericLock = new Object();
      countdown = new CountdownEvent(1);
      source = new CancellationTokenSource();
   }

   public static void Main()
   {
      Example ex = new Example();
      Thread.CurrentThread.Name = "Main";
      ex.Execute();
   }

   private void Execute()
   {
      CancellationToken token = source.Token;

      for (int threads = 1; threads <= 10; threads++)
      {
         Thread newThread = new Thread(this.GetRandomNumbers);
         newThread.Name = threads.ToString();
         newThread.Start(token);
      }
      this.GetRandomNumbers(token);

      countdown.Signal();
      // Make sure all threads have finished.
      countdown.Wait();
      source.Dispose();

      Console.WriteLine("\nTotal random numbers generated: {0:N0}", totalCount);
      Console.WriteLine("Total sum of all random numbers: {0:N2}", totalValue);
      Console.WriteLine("Random number mean: {0:N4}", totalValue/totalCount);
   }

   private void GetRandomNumbers(Object o)
   {
      CancellationToken token = (CancellationToken) o;
      double result = 0.0;
      countdown.AddCount(1);

      try {
         for (int ctr = 0; ctr < 2000000; ctr++)
         {
            // Make sure there's no corruption of Random.
            token.ThrowIfCancellationRequested();

            lock (randLock) {
               result = rand.NextDouble();
            }
            // Check for corruption of Random instance.
            if ((result == previous) && result == 0) {
               source.Cancel();
            }
            else {
               previous = result;
            }
            perThreadCtr++;
            perThreadTotal += result;
         }

         Console.WriteLine("Thread {0} finished execution.",
                           Thread.CurrentThread.Name);
         Console.WriteLine("Random numbers generated: {0:N0}", perThreadCtr);
         Console.WriteLine("Sum of random numbers: {0:N2}", perThreadTotal);
         Console.WriteLine("Random number mean: {0:N4}\n", perThreadTotal/perThreadCtr);

         // Update overall totals.
         lock (numericLock) {
            totalCount += perThreadCtr;
            totalValue += perThreadTotal;
         }
      }
      catch (OperationCanceledException e) {
         Console.WriteLine("Corruption in Thread {1}", e.GetType().Name, Thread.CurrentThread.Name);
      }
      finally {
         countdown.Signal();
      }
   }
}
// The example displays output like the following:
//       Thread 6 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,491.05
//       Random number mean: 0.5002
//
//       Thread 10 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,329.64
//       Random number mean: 0.4997
//
//       Thread 4 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,166.89
//       Random number mean: 0.5001
//
//       Thread 8 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,628.37
//       Random number mean: 0.4998
//
//       Thread Main finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,920.89
//       Random number mean: 0.5000
//
//       Thread 3 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,370.45
//       Random number mean: 0.4997
//
//       Thread 7 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,330.92
//       Random number mean: 0.4997
//
//       Thread 9 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,172.79
//       Random number mean: 0.5001
//
//       Thread 5 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,079.43
//       Random number mean: 0.5000
//
//       Thread 1 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,817.91
//       Random number mean: 0.4999
//
//       Thread 2 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,930.63
//       Random number mean: 0.5000
//
//
//       Total random numbers generated: 22,000,000
//       Total sum of all random numbers: 10,998,238.98
//       Random number mean: 0.4999

The example ensures thread-safety in the following ways:

    The ThreadStaticAttribute attribute is used to define thread-local variables that track the total number of random numbers generated and their sum for each thread.

    A lock (the lock statement in C#, the lock function in F# and the SyncLock statement in Visual Basic) protects access to the variables for the total count and sum of all random numbers generated on all threads.

    A semaphore (the CountdownEvent object) is used to ensure that the main thread blocks until all other threads complete execution.

    The example checks whether the random number generator has become corrupted by determining whether two consecutive calls to random number generation methods return 0. If corruption is detected, the example uses the CancellationTokenSource object to signal that all threads should be canceled.

    Before generating each random number, each thread checks the state of the CancellationToken object. If cancellation is requested, the example calls the CancellationToken.ThrowIfCancellationRequested method to cancel the thread.

The following example is identical to the first, except that it uses a Task object and a lambda expression instead of Thread objects.
C#

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Example
{
   static Object randLock, numericLock;
   static Random rand;
   static CancellationTokenSource source;
   double totalValue = 0.0;
   int totalCount = 0;

   public Example()
   {
      rand = new Random();
      randLock = new Object();
      numericLock = new Object();
      source = new CancellationTokenSource();
   }

   public static async Task Main()
   {
      Example ex = new Example();
      Thread.CurrentThread.Name = "Main";
      await ex.Execute();
   }

   private Task Execute()
   {
      List<Task> tasks = new List<Task>();

      for (int ctr = 0; ctr <= 10; ctr++)
      {
         CancellationToken token = source.Token;
         int taskNo = ctr;
         tasks.Add(Task.Run( () =>
            {
               double previous = 0.0;
               int taskCtr = 0;
               double taskTotal = 0.0;
               double result = 0.0;

               for (int n = 0; n < 2000000; n++)
               {
                  // Make sure there's no corruption of Random.
                  token.ThrowIfCancellationRequested();

                  lock (randLock) {
                     result = rand.NextDouble();
                  }
                  // Check for corruption of Random instance.
                  if ((result == previous) && result == 0) {
                     source.Cancel();
                  }
                  else {
                     previous = result;
                  }
                  taskCtr++;
                  taskTotal += result;
               }

               // Show result.
               Console.WriteLine("Task {0} finished execution.", taskNo);
               Console.WriteLine("Random numbers generated: {0:N0}", taskCtr);
               Console.WriteLine("Sum of random numbers: {0:N2}", taskTotal);
               Console.WriteLine("Random number mean: {0:N4}\n", taskTotal/taskCtr);

               // Update overall totals.
               lock (numericLock) {
                  totalCount += taskCtr;
                  totalValue += taskTotal;
               }
            },
         token));
      }
      try {
         await Task.WhenAll(tasks.ToArray());
         Console.WriteLine("\nTotal random numbers generated: {0:N0}", totalCount);
         Console.WriteLine("Total sum of all random numbers: {0:N2}", totalValue);
         Console.WriteLine("Random number mean: {0:N4}", totalValue/totalCount);
      }
      catch (AggregateException e) {
         foreach (Exception inner in e.InnerExceptions) {
            TaskCanceledException canc = inner as TaskCanceledException;
            if (canc != null)
               Console.WriteLine("Task #{0} cancelled.", canc.Task.Id);
            else
               Console.WriteLine("Exception: {0}", inner.GetType().Name);
         }
      }
      finally {
         source.Dispose();
      }
   }
}
// The example displays output like the following:
//       Task 1 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,502.47
//       Random number mean: 0.5003
//
//       Task 0 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,445.63
//       Random number mean: 0.5002
//
//       Task 2 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,556.04
//       Random number mean: 0.5003
//
//       Task 3 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,178.87
//       Random number mean: 0.5001
//
//       Task 4 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,819.17
//       Random number mean: 0.4999
//
//       Task 5 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,190.58
//       Random number mean: 0.5001
//
//       Task 6 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,720.21
//       Random number mean: 0.4999
//
//       Task 7 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,000.96
//       Random number mean: 0.4995
//
//       Task 8 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,499.33
//       Random number mean: 0.4997
//
//       Task 9 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 1,000,193.25
//       Random number mean: 0.5001
//
//       Task 10 finished execution.
//       Random numbers generated: 2,000,000
//       Sum of random numbers: 999,960.82
//       Random number mean: 0.5000
//
//
//       Total random numbers generated: 22,000,000
//       Total sum of all random numbers: 11,000,067.33
//       Random number mean: 0.5000

It differs from the first example in the following ways:

    The variables to keep track of the number of random numbers generated and their sum in each task are local to the task, so there is no need to use the ThreadStaticAttribute attribute.

    The static Task.WaitAll method is used to ensure that the main thread doesn't complete before all tasks have finished. There is no need for the CountdownEvent object.

    The exception that results from task cancellation is surfaced in the Task.WaitAll method. In the previous example, it is handled by each thread.

Generating different types of random numbers

The random number generator provides methods that let you generate the following kinds of random numbers:

    A series of Byte values. You determine the number of byte values by passing an array initialized to the number of elements you want the method to return to the NextBytes method. The following example generates 20 bytes.
    C# 

Random rnd = new Random();
Byte[] bytes = new Byte[20];
rnd.NextBytes(bytes);
for (int ctr = 1; ctr <= bytes.Length; ctr++) {
   Console.Write("{0,3}   ", bytes[ctr - 1]);
   if (ctr % 10 == 0) Console.WriteLine();
}

// The example displays output like the following:
//       141    48   189    66   134   212   211    71   161    56
//       181   166   220   133     9   252   222    57    62    62

A single integer. You can choose whether you want an integer from 0 to a maximum value (Int32.MaxValue - 1) by calling the Next() method, an integer between 0 and a specific value by calling the Next(Int32) method, or an integer within a range of values by calling the Next(Int32, Int32) method. In the parameterized overloads, the specified maximum value is exclusive; that is, the actual maximum number generated is one less than the specified value.

The following example calls the Next(Int32, Int32) method to generate 10 random numbers between -10 and 10. Note that the second argument to the method specifies the exclusive upper bound of the range of random values returned by the method. In other words, the largest integer that the method can return is one less than this value.
C#

Random rnd = new Random();
for (int ctr = 0; ctr < 10; ctr++) {
   Console.Write("{0,3}   ", rnd.Next(-10, 11));
}

// The example displays output like the following:
//    2     9    -3     2     4    -7    -3    -8    -8     5

A single floating-point value from 0.0 to less than 1.0 by calling the NextDouble method. The exclusive upper bound of the random number returned by the method is 1, so its actual upper bound is 0.99999999999999978. The following example generates 10 random floating-point numbers.
C#

    Random rnd = new Random();
    for (int ctr = 0; ctr < 10; ctr++) {
       Console.Write("{0,-19:R}   ", rnd.NextDouble());
       if ((ctr + 1) % 3 == 0) Console.WriteLine();
    }

    // The example displays output like the following:
    //    0.7911680553998649    0.0903414949264105    0.79776258291572455
    //    0.615568345233597     0.652644504165577     0.84023809378977776
    //    0.099662564741290441   0.91341467383942321  0.96018602045261581
    //    0.74772306473354022

Important

The Next(Int32, Int32) method allows you to specify the range of the returned random number. However, the maxValue parameter, which specifies the upper range returned number, is an exclusive, not an inclusive, value. This means that the method call Next(0, 100) returns a value between 0 and 99, and not between 0 and 100.

You can also use the Random class for such tasks as generating random T:System.Boolean values, generating random floating point values with a range other than 0 to 1, generating random 64-bit integers, and randomly retrieving a unique element from an array or collection. For these and other common tasks, see the How do you use System.Random to… section.

Substituting your own algorithm

You can implement your own random number generator by inheriting from the Random class and supplying your random number generation algorithm. To supply your own algorithm, you must override the Sample method, which implements the random number generation algorithm. You should also override the Next(), Next(Int32, Int32), and NextBytes methods to ensure that they call your overridden Sample method. You don't have to override the Next(Int32) and NextDouble methods.

For an example that derives from the Random class and modifies its default pseudo-random number generator, see the Sample reference page.

How do you use System.Random to...

The following sections discuss and provide sample code for some of the ways you might want to use random numbers in your app.

Retrieve the same sequence of random values

Sometimes you want to generate the same sequence of random numbers in software test scenarios and in game playing. Testing with the same sequence of random numbers allows you to detect regressions and confirm bug fixes. Using the same sequence of random number in games allows you to replay previous games.

You can generate the same sequence of random numbers by providing the same seed value to the Random(Int32) constructor. The seed value provides a starting value for the pseudo-random number generation algorithm. The following example uses 100100 as an arbitrary seed value to instantiate the Random object, displays 20 random floating-point values, and persists the seed value. It then restores the seed value, instantiates a new random number generator, and displays the same 20 random floating-point values. Note that the example may produce different sequences of random numbers if run on different versions of the .NET Framework.
C#

using System;
using System.IO;

public class Example
{
   public static void Main()
   {
      int seed = 100100;
      ShowRandomNumbers(seed);
      Console.WriteLine();

      PersistSeed(seed);

      DisplayNewRandomNumbers();
   }

   private static void ShowRandomNumbers(int seed)
   {
      Random rnd = new Random(seed);
      for (int ctr = 0; ctr <= 20; ctr++)
         Console.WriteLine(rnd.NextDouble());
   }

   private static void PersistSeed(int seed)
   {
      FileStream fs = new FileStream(@".\seed.dat", FileMode.Create);
      BinaryWriter bin = new BinaryWriter(fs);
      bin.Write(seed);
      bin.Close();
   }

   private static void DisplayNewRandomNumbers()
   {
      FileStream fs = new FileStream(@".\seed.dat", FileMode.Open);
      BinaryReader bin = new BinaryReader(fs);
      int seed = bin.ReadInt32();
      bin.Close();

      Random rnd = new Random(seed);
      for (int ctr = 0; ctr <= 20; ctr++)
         Console.WriteLine(rnd.NextDouble());
   }
}
// The example displays output like the following:
//       0.500193602172748
//       0.0209461245783354
//       0.465869495396442
//       0.195512794514891
//       0.928583675496552
//       0.729333720509584
//       0.381455668891527
//       0.0508996467343064
//       0.019261200921266
//       0.258578445417145
//       0.0177532266908107
//       0.983277184415272
//       0.483650274334313
//       0.0219647376900375
//       0.165910115077118
//       0.572085966622497
//       0.805291457942357
//       0.927985211335116
//       0.4228545699375
//       0.523320379910674
//       0.157783938645285
//
//       0.500193602172748
//       0.0209461245783354
//       0.465869495396442
//       0.195512794514891
//       0.928583675496552
//       0.729333720509584
//       0.381455668891527
//       0.0508996467343064
//       0.019261200921266
//       0.258578445417145
//       0.0177532266908107
//       0.983277184415272
//       0.483650274334313
//       0.0219647376900375
//       0.165910115077118
//       0.572085966622497
//       0.805291457942357
//       0.927985211335116
//       0.4228545699375
//       0.523320379910674
//       0.157783938645285

Retrieve unique sequences of random numbers

Providing different seed values to instances of the Random class causes each random number generator to produce a different sequence of values. You can provide a seed value either explicitly by calling the Random(Int32) constructor, or implicitly by calling the Random() constructor. Most developers call the parameterless constructor, which uses the system clock. The following example uses this approach to instantiate two Random instances. Each instance displays a series of 10 random integers.
C#

using System;
using System.Threading;

public class Example
{
   public static void Main()
   {
      Console.WriteLine("Instantiating two random number generators...");
      Random rnd1 = new Random();
      Thread.Sleep(2000);
      Random rnd2 = new Random();

      Console.WriteLine("\nThe first random number generator:");
      for (int ctr = 1; ctr <= 10; ctr++)
         Console.WriteLine("   {0}", rnd1.Next());

      Console.WriteLine("\nThe second random number generator:");
      for (int ctr = 1; ctr <= 10; ctr++)
         Console.WriteLine("   {0}", rnd2.Next());
   }
}
// The example displays output like the following:
//       Instantiating two random number generators...
//
//       The first random number generator:
//          643164361
//          1606571630
//          1725607587
//          2138048432
//          496874898
//          1969147632
//          2034533749
//          1840964542
//          412380298
//          47518930
//
//       The second random number generator:
//          1251659083
//          1514185439
//          1465798544
//          517841554
//          1821920222
//          195154223
//          1538948391
//          1548375095
//          546062716
//          897797880

However, because of its finite resolution, the system clock doesn't detect time differences that are less than approximately 15 milliseconds. Therefore, if your code calls the Random() overload on the .NET Framework to instantiate two Random objects in succession, you might inadvertently be providing the objects with identical seed values. (The Random class in .NET Core does not have this limitation.) To see this in the previous example, comment out the Thread.Sleep method call, and compile and run the example again.

To prevent this from happening, we recommend that you instantiate a single Random object rather than multiple ones. However, since Random isn't thread safe, you must use some synchronization device if you access a Random instance from multiple threads; for more information, see The Random class and thread safety earlier in this topic. Alternately, you can use a delay mechanism, such as the Sleep method used in the previous example, to ensure that the instantiations occur more than 15 millisecond apart.

Retrieve integers in a specified range

You can retrieve integers in a specified range by calling the Next(Int32, Int32) method, which lets you specify both the lower and the upper bound of the numbers you'd like the random number generator to return. The upper bound is an exclusive, not an inclusive, value. That is, it isn't included in the range of values returned by the method. The following example uses this method to generate random integers between -10 and 10. Note that it specifies 11, which is one greater than the desired value, as the value of the maxValue argument in the method call.
C#

Random rnd = new Random();
for (int ctr = 1; ctr <= 15; ctr++) {
   Console.Write("{0,3}    ", rnd.Next(-10, 11));
   if(ctr % 5 == 0) Console.WriteLine();
}

// The example displays output like the following:
//        -2     -5     -1     -2     10
//        -3      6     -4     -8      3
//        -7     10      5     -2      4

Retrieve integers with a specified number of digits

You can call the Next(Int32, Int32) method to retrieve numbers with a specified number of digits. For example, to retrieve numbers with four digits (that is, numbers that range from 1000 to 9999), you call the Next(Int32, Int32) method with a minValue value of 1000 and a maxValue value of 10000, as the following example shows.
C#

Random rnd = new Random();
for (int ctr = 1; ctr <= 50; ctr++) {
   Console.Write("{0,3}    ", rnd.Next(1000, 10000));
   if(ctr % 10 == 0) Console.WriteLine();
}

// The example displays output like the following:
//    9570    8979    5770    1606    3818    4735    8495    7196    7070    2313
//    5279    6577    5104    5734    4227    3373    7376    6007    8193    5540
//    7558    3934    3819    7392    1113    7191    6947    4963    9179    7907
//    3391    6667    7269    1838    7317    1981    5154    7377    3297    5320
//    9869    8694    2684    4949    2999    3019    2357    5211    9604    2593

Retrieve floating-point values in a specified range

The NextDouble method returns random floating-point values that range from 0 to less than 1. However, you'll often want to generate random values in some other range.

If the interval between the minimum and maximum desired values is 1, you can add the difference between the desired starting interval and 0 to the number returned by the NextDouble method. The following example does this to generate 10 random numbers between -1 and 0.
C#

Random rnd = new Random();
for (int ctr = 1; ctr <= 10; ctr++)
   Console.WriteLine(rnd.NextDouble() - 1);

// The example displays output like the following:
//       -0.930412760437658
//       -0.164699016215605
//       -0.9851692803135
//       -0.43468508843085
//       -0.177202483255976
//       -0.776813320245972
//       -0.0713201854710096
//       -0.0912875561468711
//       -0.540621722368813
//       -0.232211863730201

To generate random floating-point numbers whose lower bound is 0 but upper bound is greater than 1 (or, in the case of negative numbers, whose lower bound is less than -1 and upper bound is 0), multiply the random number by the non-zero bound. The following example does this to generate 20 million random floating-point numbers that range from 0 to Int64.MaxValue. In also displays the distribution of the random values generated by the method.
C#

const long ONE_TENTH = 922337203685477581;

Random rnd = new Random();
double number;
int[] count = new int[10];

// Generate 20 million integer values between.
for (int ctr = 1; ctr <= 20000000; ctr++) {
   number = rnd.NextDouble() * Int64.MaxValue;
   // Categorize random numbers into 10 groups.
   count[(int) (number / ONE_TENTH)]++;
}
// Display breakdown by range.
Console.WriteLine("{0,28} {1,32}   {2,7}\n", "Range", "Count", "Pct.");
for (int ctr = 0; ctr <= 9; ctr++)
   Console.WriteLine("{0,25:N0}-{1,25:N0}  {2,8:N0}   {3,7:P2}", ctr * ONE_TENTH,
                      ctr < 9 ? ctr * ONE_TENTH + ONE_TENTH - 1 : Int64.MaxValue,
                      count[ctr], count[ctr]/20000000.0);

// The example displays output like the following:
//                           Range                            Count      Pct.
//
//                            0-  922,337,203,685,477,580  1,996,148    9.98 %
//      922,337,203,685,477,581-1,844,674,407,370,955,161  2,000,293   10.00 %
//    1,844,674,407,370,955,162-2,767,011,611,056,432,742  2,000,094   10.00 %
//    2,767,011,611,056,432,743-3,689,348,814,741,910,323  2,000,159   10.00 %
//    3,689,348,814,741,910,324-4,611,686,018,427,387,904  1,999,552   10.00 %
//    4,611,686,018,427,387,905-5,534,023,222,112,865,485  1,998,248    9.99 %
//    5,534,023,222,112,865,486-6,456,360,425,798,343,066  2,000,696   10.00 %
//    6,456,360,425,798,343,067-7,378,697,629,483,820,647  2,001,637   10.01 %
//    7,378,697,629,483,820,648-8,301,034,833,169,298,228  2,002,870   10.01 %
//    8,301,034,833,169,298,229-9,223,372,036,854,775,807  2,000,303   10.00 %

To generate random floating-point numbers between two arbitrary values, like the Next(Int32, Int32) method does for integers, use the following formula:
C#

Random.NextDouble() * (maxValue - minValue) + minValue  

The following example generates 1 million random numbers that range from 10.0 to 11.0, and displays their distribution.
C#

Random rnd = new Random();
int lowerBound = 10;
int upperBound = 11;
int[] range = new int[10];
for (int ctr = 1; ctr <= 1000000; ctr++) {
   Double value = rnd.NextDouble() * (upperBound - lowerBound) + lowerBound;
   range[(int) Math.Truncate((value - lowerBound) * 10)]++;
}

for (int ctr = 0; ctr <= 9; ctr++) {
   Double lowerRange = 10 + ctr * .1;
   Console.WriteLine("{0:N1} to {1:N1}: {2,8:N0}  ({3,7:P2})",
                     lowerRange, lowerRange + .1, range[ctr],
                     range[ctr] / 1000000.0);
}

// The example displays output like the following:
//       10.0 to 10.1:   99,929  ( 9.99 %)
//       10.1 to 10.2:  100,189  (10.02 %)
//       10.2 to 10.3:   99,384  ( 9.94 %)
//       10.3 to 10.4:  100,240  (10.02 %)
//       10.4 to 10.5:   99,397  ( 9.94 %)
//       10.5 to 10.6:  100,580  (10.06 %)
//       10.6 to 10.7:  100,293  (10.03 %)
//       10.7 to 10.8:  100,135  (10.01 %)
//       10.8 to 10.9:   99,905  ( 9.99 %)
//       10.9 to 11.0:   99,948  ( 9.99 %)

Generate random Boolean values

The Random class doesn't provide methods that generate Boolean values. However, you can define your own class or method to do that. The following example defines a class, BooleanGenerator, with a single method, NextBoolean. The BooleanGenerator class stores a Random object as a private variable. The NextBoolean method calls the Random.Next(Int32, Int32) method and passes the result to the Convert.ToBoolean(Int32) method. Note that 2 is used as the argument to specify the upper bound of the random number. Since this is an exclusive value, the method call returns either 0 or 1.
C#

using System;

public class Example
{
   public static void Main()
   {
      // Instantiate the Boolean generator.
      BooleanGenerator boolGen = new BooleanGenerator();
      int totalTrue = 0, totalFalse = 0;

      // Generate 1,0000 random Booleans, and keep a running total.
      for (int ctr = 0; ctr < 1000000; ctr++) {
          bool value = boolGen.NextBoolean();
          if (value)
             totalTrue++;
          else
             totalFalse++;
      }
      Console.WriteLine("Number of true values:  {0,7:N0} ({1:P3})",
                        totalTrue,
                        ((double) totalTrue)/(totalTrue + totalFalse));
      Console.WriteLine("Number of false values: {0,7:N0} ({1:P3})",
                        totalFalse,
                        ((double) totalFalse)/(totalTrue + totalFalse));
   }
}

public class BooleanGenerator
{
   Random rnd;

   public BooleanGenerator()
   {
      rnd = new Random();
   }

   public bool NextBoolean()
   {
      return rnd.Next(0, 2) == 1;
   }
}
// The example displays output like the following:
//       Number of true values:  500,004 (50.000 %)
//       Number of false values: 499,996 (50.000 %)

Instead of creating a separate class to generate random Boolean values, the example could simply have defined a single method. In that case, however, the Random object should have been defined as a class-level variable to avoid instantiating a new Random instance in each method call. In Visual Basic, the Random instance can be defined as a Static variable in the NextBoolean method. The following example provides an implementation.
C#

Random rnd = new Random();

int totalTrue = 0, totalFalse = 0;

// Generate 1,000,000 random Booleans, and keep a running total.
for (int ctr = 0; ctr < 1000000; ctr++) {
    bool value = NextBoolean();
    if (value)
       totalTrue++;
    else
       totalFalse++;
}
Console.WriteLine("Number of true values:  {0,7:N0} ({1:P3})",
                  totalTrue,
                  ((double) totalTrue)/(totalTrue + totalFalse));
Console.WriteLine("Number of false values: {0,7:N0} ({1:P3})",
                  totalFalse,
                  ((double) totalFalse)/(totalTrue + totalFalse));

bool NextBoolean()
{
   return rnd.Next(0, 2) == 1;
}

// The example displays output like the following:
//       Number of true values:  499,777 (49.978 %)
//       Number of false values: 500,223 (50.022 %)

Generate random 64-bit integers

The overloads of the Next method return 32-bit integers. However, in some cases, you might want to work with 64-bit integers. You can do this as follows:

    Call the NextDouble method to retrieve a double-precision floating point value.

    Multiply that value by Int64.MaxValue.

The following example uses this technique to generate 20 million random long integers and categorizes them in 10 equal groups. It then evaluates the distribution of the random numbers by counting the number in each group from 0 to Int64.MaxValue. As the output from the example shows, the numbers are distributed more or less equally through the range of a long integer.
C#

const long ONE_TENTH = 922337203685477581;

Random rnd = new Random();
long number;
int[] count = new int[10];

// Generate 20 million long integers.
for (int ctr = 1; ctr <= 20000000; ctr++) {
   number = (long) (rnd.NextDouble() * Int64.MaxValue);
   // Categorize random numbers.
   count[(int) (number / ONE_TENTH)]++;
}
// Display breakdown by range.
Console.WriteLine("{0,28} {1,32}   {2,7}\n", "Range", "Count", "Pct.");
for (int ctr = 0; ctr <= 9; ctr++)
   Console.WriteLine("{0,25:N0}-{1,25:N0}  {2,8:N0}   {3,7:P2}", ctr * ONE_TENTH,
                      ctr < 9 ? ctr * ONE_TENTH + ONE_TENTH - 1 : Int64.MaxValue,
                      count[ctr], count[ctr]/20000000.0);

// The example displays output like the following:
//                           Range                            Count      Pct.
//
//                            0-  922,337,203,685,477,580  1,996,148    9.98 %
//      922,337,203,685,477,581-1,844,674,407,370,955,161  2,000,293   10.00 %
//    1,844,674,407,370,955,162-2,767,011,611,056,432,742  2,000,094   10.00 %
//    2,767,011,611,056,432,743-3,689,348,814,741,910,323  2,000,159   10.00 %
//    3,689,348,814,741,910,324-4,611,686,018,427,387,904  1,999,552   10.00 %
//    4,611,686,018,427,387,905-5,534,023,222,112,865,485  1,998,248    9.99 %
//    5,534,023,222,112,865,486-6,456,360,425,798,343,066  2,000,696   10.00 %
//    6,456,360,425,798,343,067-7,378,697,629,483,820,647  2,001,637   10.01 %
//    7,378,697,629,483,820,648-8,301,034,833,169,298,228  2,002,870   10.01 %
//    8,301,034,833,169,298,229-9,223,372,036,854,775,807  2,000,303   10.00 %

An alternative technique that uses bit manipulation does not generate truly random numbers. This technique calls Next() to generate two integers, left-shifts one by 32 bits, and ORs them together. This technique has two limitations:

    Because bit 31 is the sign bit, the value in bit 31 of the resulting long integer is always 0. This can be addressed by generating a random 0 or 1, left-shifting it 31 bits, and ORing it with the original random long integer.

    More seriously, because the probability that the value returned by Next() will be 0, there will be few if any random numbers in the range 0x0-0x00000000FFFFFFFF.

Retrieve bytes in a specified range

The overloads of the Next method allow you to specify the range of random numbers, but the NextBytes method does not. The following example implements a NextBytes method that lets you specify the range of the returned bytes. It defines a Random2 class that derives from Random and overloads its NextBytes method.
C#

using System;

public class Example
{
   public static void Main()
   {
       Random2 rnd = new Random2();
       Byte[] bytes = new Byte[10000];
       int[] total = new int[101];
       rnd.NextBytes(bytes, 0, 101);

       // Calculate how many of each value we have.
       foreach (var value in bytes)
          total[value]++;

       // Display the results.
       for (int ctr = 0; ctr < total.Length; ctr++) {
           Console.Write("{0,3}: {1,-3}   ", ctr, total[ctr]);
           if ((ctr + 1) % 5 == 0) Console.WriteLine();
       }
   }
}

public class Random2 : Random
{
   public Random2() : base()
   {}

   public Random2(int seed) : base(seed)
   {}

   public void NextBytes(byte[] bytes, byte minValue, byte maxValue)
   {
      for (int ctr = bytes.GetLowerBound(0); ctr <= bytes.GetUpperBound(0); ctr++)
         bytes[ctr] = (byte) Next(minValue, maxValue);
   }
}
// The example displays output like the following:
//         0: 115     1: 119     2: 92      3: 98      4: 92
//         5: 102     6: 103     7: 84      8: 93      9: 116
//        10: 91     11: 98     12: 106    13: 91     14: 92
//        15: 101    16: 100    17: 96     18: 97     19: 100
//        20: 101    21: 106    22: 112    23: 82     24: 85
//        25: 102    26: 107    27: 98     28: 106    29: 102
//        30: 109    31: 108    32: 94     33: 101    34: 107
//        35: 101    36: 86     37: 100    38: 101    39: 102
//        40: 113    41: 95     42: 96     43: 89     44: 99
//        45: 81     46: 89     47: 105    48: 100    49: 85
//        50: 103    51: 103    52: 93     53: 89     54: 91
//        55: 97     56: 105    57: 97     58: 110    59: 86
//        60: 116    61: 94     62: 117    63: 98     64: 110
//        65: 93     66: 102    67: 100    68: 105    69: 83
//        70: 81     71: 97     72: 85     73: 70     74: 98
//        75: 100    76: 110    77: 114    78: 83     79: 90
//        80: 96     81: 112    82: 102    83: 102    84: 99
//        85: 81     86: 100    87: 93     88: 99     89: 118
//        90: 95     91: 124    92: 108    93: 96     94: 104
//        95: 106    96: 99     97: 99     98: 92     99: 99
//       100: 108

The NextBytes(Byte[], Byte, Byte) method wraps a call to the Next(Int32, Int32) method and specifies the minimum value and one greater than the maximum value (in this case, 0 and 101) that we want returned in the byte array. Because we are sure that the integer values returned by the Next method are within the range of the Byte data type, we can safely cast them (in C# and F#) or convert them (in Visual Basic) from integers to bytes.

Retrieve an element from an array or collection at random

Random numbers often serve as indexes to retrieve values from arrays or collections. To retrieve a random index value, you can call the Next(Int32, Int32) method, and use the lower bound of the array as the value of its minValue argument and one greater than the upper bound of the array as the value of its maxValue argument. For a zero-based array, this is equivalent to its Length property, or one greater than the value returned by the Array.GetUpperBound method. The following example randomly retrieves the name of a city in the United States from an array of cities.
C#

String[] cities = { "Atlanta", "Boston", "Chicago", "Detroit",
                    "Fort Wayne", "Greensboro", "Honolulu", "Indianapolis",
                    "Jersey City", "Kansas City", "Los Angeles",
                    "Milwaukee", "New York", "Omaha", "Philadelphia",
                    "Raleigh", "San Francisco", "Tulsa", "Washington" };
Random rnd = new Random();
int index = rnd.Next(0, cities.Length);
Console.WriteLine("Today's city of the day: {0}",
                  cities[index]);

// The example displays output like the following:
//   Today's city of the day: Honolulu

Retrieve a unique element from an array or collection

A random number generator can always return duplicate values. As the range of numbers becomes smaller or the number of values generated becomes larger, the probability of duplicates grows. If random values must be unique, more numbers are generated to compensate for duplicates, resulting in increasingly poor performance.

There are a number of techniques to handle this scenario. One common solution is to create an array or collection that contains the values to be retrieved, and a parallel array that contains random floating-point numbers. The second array is populated with random numbers at the time the first array is created, and the Array.Sort(Array, Array) method is used to sort the first array by using the values in the parallel array.

For example, if you're developing a Solitaire game, you want to ensure that each card is used only once. Instead of generating random numbers to retrieve a card and tracking whether that card has already been dealt, you can create a parallel array of random numbers that can be used to sort the deck. Once the deck is sorted, your app can maintain a pointer to indicate the index of the next card on the deck.

The following example illustrates this approach. It defines a Card class that represents a playing card and a Dealer class that deals a deck of shuffled cards. The Dealer class constructor populates two arrays: a deck array that has class scope and that represents all the cards in the deck; and a local order array that has the same number of elements as the deck array and is populated with randomly generated Double values. The Array.Sort(Array, Array) method is then called to sort the deck array based on the values in the order array.
C#

using System;

// A class that represents an individual card in a playing deck.
public class Card
{
   public Suit Suit;
   public FaceValue FaceValue;

   public override String ToString()
   {
      return String.Format("{0:F} of {1:F}", this.FaceValue, this.Suit);
   }
}

public enum Suit { Hearts, Diamonds, Spades, Clubs };

public enum FaceValue  { Ace = 1, Two, Three, Four, Five, Six,
                         Seven, Eight, Nine, Ten, Jack, Queen,
                         King };

public class Dealer
{
   Random rnd;
   // A deck of cards, without Jokers.
   Card[] deck = new Card[52];
   // Parallel array for sorting cards.
   Double[] order = new Double[52];
   // A pointer to the next card to deal.
   int ptr = 0;
   // A flag to indicate the deck is used.
   bool mustReshuffle = false;

   public Dealer()
   {
      rnd = new Random();
      // Initialize the deck.
      int deckCtr = 0;
      foreach (var suit in Enum.GetValues(typeof(Suit))) {
         foreach (var faceValue in Enum.GetValues(typeof(FaceValue))) {
            Card card = new Card();
            card.Suit = (Suit) suit;
            card.FaceValue = (FaceValue) faceValue;
            deck[deckCtr] = card;
            deckCtr++;
         }
      }

      for (int ctr = 0; ctr < order.Length; ctr++)
         order[ctr] = rnd.NextDouble();

      Array.Sort(order, deck);
   }

   public Card[] Deal(int numberToDeal)
   {
      if (mustReshuffle) {
         Console.WriteLine("There are no cards left in the deck");
         return null;
      }

      Card[] cardsDealt = new Card[numberToDeal];
      for (int ctr = 0; ctr < numberToDeal; ctr++) {
         cardsDealt[ctr] = deck[ptr];
         ptr++;
         if (ptr == deck.Length)
            mustReshuffle = true;

         if (mustReshuffle & ctr < numberToDeal - 1) {
            Console.WriteLine("Can only deal the {0} cards remaining on the deck.",
                              ctr + 1);
            return cardsDealt;
         }
      }
      return cardsDealt;
   }
}

public class Example
{
   public static void Main()
   {
      Dealer dealer = new Dealer();
      ShowCards(dealer.Deal(20));
   }

   private static void ShowCards(Card[] cards)
   {
      foreach (var card in cards)
         if (card != null)
            Console.WriteLine("{0} of {1}", card.FaceValue, card.Suit);
   }
}
// The example displays output like the following:
//       Six of Diamonds
//       King of Clubs
//       Eight of Clubs
//       Seven of Clubs
//       Queen of Clubs
//       King of Hearts
//       Three of Spades
//       Ace of Clubs
//       Four of Hearts
//       Three of Diamonds
//       Nine of Diamonds
//       Two of Hearts
//       Ace of Hearts
//       Three of Hearts
//       Four of Spades
//       Eight of Hearts
//       Queen of Diamonds
//       Two of Clubs
//       Four of Diamonds
//       Jack of Hearts

Notes to Inheritors

In the .NET Framework 1.0 and 1.1, a minimum implementation of a class derived from Random required overriding the Sample() method to define a new or modified algorithm for generating random numbers. The derived class could then rely on the base class implementation of the Next(), Next(Int32), Next(Int32, Int32), NextBytes(Byte[]), and NextDouble() methods to call the derived class implementation of the Sample() method.

In the .NET Framework 2.0 and later, the behavior of the Next(), Next(Int32, Int32), and NextBytes(Byte[]) methods have changed so that these methods do not necessarily call the derived class implementation of the Sample() method. As a result, classes derived from Random that target the .NET Framework 2.0 and later should also override these three methods.
Notes to Callers

The implementation of the random number generator in the Random class isn't guaranteed to remain the same across major versions of the .NET Framework. As a result, you shouldn't assume that the same seed will result in the same pseudo-random sequence in different versions of the .NET Framework.
Constructors
Random() 	

Initializes a new instance of the Random class using a default seed value.
Random(Int32) 	

Initializes a new instance of the Random class, using the specified seed value.
Properties
Shared 	

Provides a thread-safe Random instance that may be used concurrently from any thread.
Methods
Equals(Object) 	

Determines whether the specified object is equal to the current object.
(Inherited from Object)
GetHashCode() 	

Serves as the default hash function.
(Inherited from Object)
GetType() 	

Gets the Type of the current instance.
(Inherited from Object)
MemberwiseClone() 	

Creates a shallow copy of the current Object.
(Inherited from Object)
Next() 	

Returns a non-negative random integer.
Next(Int32) 	

Returns a non-negative random integer that is less than the specified maximum.
Next(Int32, Int32) 	

Returns a random integer that is within a specified range.
NextBytes(Byte[]) 	

Fills the elements of a specified array of bytes with random numbers.
NextBytes(Span<Byte>) 	

Fills the elements of a specified span of bytes with random numbers.
NextDouble() 	

Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.
NextInt64() 	

Returns a non-negative random integer.
NextInt64(Int64) 	

Returns a non-negative random integer that is less than the specified maximum.
NextInt64(Int64, Int64) 	

Returns a random integer that is within a specified range.
NextSingle() 	

Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.
Sample() 	

Returns a random floating-point number between 0.0 and 1.0.
ToString() 	

Returns a string that represents the current object.
(Inherited from Object)
Applies to
Product 	Versions
.NET 	Core 1.0, Core 1.1, Core 2.0, Core 2.1, Core 2.2, Core 3.0, Core 3.1, 5, 6, 7
.NET Framework 	1.1, 2.0, 3.0, 3.5, 4.0, 4.5, 4.5.1, 4.5.2, 4.6, 4.6.1, 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8
.NET Standard 	1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 2.0, 2.1
UWP 	10.0
Xamarin.iOS 	10.8
Xamarin.Mac 	3.0
Recommended content

    Multidimensional Arrays - C# Programming Guide

    Arrays in C# can have more than one dimension. This example declaration creates a two-dimensional array of four rows and two columns.
    Arrays - C# Programming Guide

    Store multiple variables of the same type in an array data structure in C#. Declare an array by specifying a type or specify Object to store any type.
    Math.Pow(Double, Double) Method (System)

    Returns a specified number raised to the specified power.
    Int32.Parse Method (System)

    Converts the string representation of a number to its 32-bit signed integer equivalent.

In this article

    Definition
    Examples
    Remarks
    Notes to Inheritors

    Previous Versions
    Blog
    Contribute
    Privacy
    Terms of Use
    Trademarks
    © Microsoft 2022

