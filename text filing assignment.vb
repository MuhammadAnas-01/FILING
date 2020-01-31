Module Module1
    Dim Name, IDnum As String

    Sub Main()
        Dim choice As Integer = 0
        Do
            Call display()
            Do
                Console.Write("Enter your choice: ") : choice = Console.ReadLine
            Loop Until choice >= 0 And choice <= 5
            If choice = 1 Then
                Call task1()
            ElseIf choice = 2 Then
                Call task2()
            ElseIf choice = 3 Then
                Call task3()
            ElseIf choice = 4 Then
                Call task4()
            ElseIf choice = 5 Then
                Call task5()
            ElseIf choice < 0 And choice > 5 Then
                Console.WriteLine("invalid choice")
                Console.ReadKey()
            End If
        Loop Until choice = 0

    End Sub
    Sub display()
        Console.Clear()
        Console.WriteLine("0: quit")
        Console.WriteLine("1: creat a file to enter members detail")
        Console.WriteLine("2:  see the record entered")
        Console.WriteLine("3: search the name from the file ")
        Console.WriteLine("4: enter new memebers data in existing file")
        Console.WriteLine("5: add additional information")

    End Sub
    Sub task1()
        Dim more As String
        Name = ""
        IDnum = ""

        FileOpen(1, "D:\C\Desktop\vb programs\filing\textfile.txt", OpenMode.Output)
        Do
            Console.WriteLine("Enter the name of member")
            Name = Console.ReadLine
            Console.WriteLine("Enter the ID number")
            IDnum = Console.ReadLine

            WriteLine(1, Name)
            WriteLine(1, IDnum)

            Console.WriteLine(" Do you want to enter more records? (Y/N)")
            more = Console.ReadLine

        Loop Until more = "N" Or more = "n"
        FileClose(1)
    End Sub
    Sub task2()

        FileOpen(1, "D:\C\Desktop\vb programs\filing\textfile.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, Name)
            Input(1, IDnum)
            Console.WriteLine(Name)
            Console.WriteLine(IDnum)

        End While
        FileClose(1)
        Console.ReadLine()
    End Sub
    Sub task3()
        Dim Fname As String
        Dim isfound As Boolean
        isfound = False

        FileOpen(1, "D:\C\Desktop\vb programs\filing\textfile.txt", OpenMode.Input)
        Console.WriteLine("enter the name you have to search: ") : Fname = Console.ReadLine
        While Not EOF(1)
            Input(1, Name)
            Input(1, IDnum)
            If Fname = Name Then
                isfound = True
            End If
        End While
        If isfound = True Then Console.WriteLine("your searched name has been found: " & Fname)
        If isfound = False Then Console.WriteLine("your searched name has not been found ")
        Console.ReadLine()
    End Sub
    Sub task4()
        Dim more As String
        Dim Name, IDnum As String
        Name = ""
        IDnum = ""

        FileOpen(1, "D:\C\Desktop\vb programs\filing\textfile.txt", OpenMode.Append)
        Do
            Console.WriteLine("Enter the name of member")
            Name = Console.ReadLine
            Console.WriteLine("Enter the ID number")
            IDnum = Console.ReadLine

            WriteLine(1, Name)
            WriteLine(1, IDnum)

            Console.WriteLine(" Do you want to enter more records? (Y/N)")
            more = Console.ReadLine

        Loop Until more = "N" Or more = "n"
        FileClose(1)

    End Sub
    Sub task5()
        Dim telephoneNum As String
        Dim MemDate As String
        Dim Name, IDnum As String
        Name = ""
        IDnum = ""

        FileOpen(1, "D:\C\Desktop\vb programs\filing\textfile.txt", OpenMode.Input)
        FileOpen(2, "D:\C\Desktop\vb programs\filing\textfile2.txt", OpenMode.Output)
        While Not EOF(1)
            Input(1, Name)
            Input(1, IDnum)
            Console.WriteLine(Name)
            Console.WriteLine(IDnum)
            Console.WriteLine("Enter the telephone number: ")
            telephoneNum = Console.ReadLine
            Console.WriteLine("Enter the start of membership date: ")
            MemDate = Console.ReadLine

            WriteLine(2, Name)
            WriteLine(2, IDnum)
            WriteLine(2, telephoneNum)
            WriteLine(2, MemDate)
        End While
        FileClose(1)
        FileClose(2)
    End Sub
End Module
