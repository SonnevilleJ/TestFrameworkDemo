Imports NUnit.Framework

<TestClass>
Public Class MSTest_VBDemoTests
    Private _demo As VBDemo

    <TestInitialize>
    Public Sub Initialize()
        Console.WriteLine("Optional method - Initialize method runs before each test")
        _demo = New VBDemo()
    End Sub

    <TestCleanup>
    Public Sub Cleanup()
        Console.WriteLine("Optional method - Cleanup runs after each test")
    End Sub

    <TestMethod>
    Public Sub MSTest_Test1()
        Console.WriteLine("Test1, set state to 5")
        _demo.State = 5
        Console.WriteLine("Test1, call Double()")
        _demo.[Double]()
        Console.WriteLine("Test1, assert state is 10")
        Assert.AreEqual(10, _demo.State)
    End Sub

    <TestMethod>
    Public Sub MSTest_Test2()
        Console.WriteLine("Test2, set state to 20")
        _demo.State = 20
        Console.WriteLine("Test2, call Double()")
        _demo.[Double]()
        Console.WriteLine("Test2, assert state is 40")
        Assert.AreEqual(40, _demo.State)
    End Sub
End Class