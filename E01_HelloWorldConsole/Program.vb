Imports System

Module Program
  Sub Main(args As String())
    Console.Write("Enter a number...")
    Dim input As String = Console.ReadLine()

    Try
      Dim num As Integer = Integer.Parse(input)
      Console.Write("The square of this number is ")
      Console.WriteLine(num * num)
    Catch ex As Exception
      Console.WriteLine("This is not a valid input. Only type digits.")
    End Try
  End Sub
End Module
