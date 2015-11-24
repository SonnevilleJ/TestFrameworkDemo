Imports NUnit.Framework

<TestFixture>
Public Class NUnitVBDemoTests
    Private _demo As VBDemo

    <SetUp>
    Public Sub SetUp()
        Console.WriteLine("Optional method - SetUp method runs before each test")
        _demo = New VBDemo()
    End Sub

    <TearDown>
    Public Sub TearDown()
        Console.WriteLine("Optional method - TearDown runs after each test")
    End Sub

    <Test>
    Public Sub NUnit_Test1()
        Console.WriteLine("Test1, set state to 5")
        _demo.State = 5
        Console.WriteLine("Test1, call Double()")
        _demo.[Double]()
        Console.WriteLine("Test1, assert state is 10")
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(10, _demo.State)
    End Sub

    <Test>
    Public Sub NUnit_Test2()
        Console.WriteLine("Test2, set state to 20")
        _demo.State = 20
        Console.WriteLine("Test2, call Double()")
        _demo.[Double]()
        Console.WriteLine("Test2, assert state is 40")
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(40, _demo.State)
    End Sub

    <TestCase(20, 40)>
    <TestCase(30, 60)>
    <TestCase(50, 100)>
    <TestCase(-1, -2)>
    <TestCase(0, 0)>
    Public Sub NUnit_TestCaseDemo(initialState As Integer, expected As Integer)
        Console.WriteLine("TestCaseDemo, set state to {0}", initialState)
        _demo.State = initialState
        Console.WriteLine("TestCaseDemo, call Double()")
        _demo.[Double]()
        Console.WriteLine("TestCaseDemo, assert state is {0}", expected)
        Assert.AreEqual(expected, _demo.State)
    End Sub
End Class