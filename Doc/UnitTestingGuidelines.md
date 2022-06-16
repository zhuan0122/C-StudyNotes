# Unit Testing Guidelines

## Table of Contents
1. [Introduction](#Introduction)
2. [Test delimitation](#Test-delimitation)
3. [Test disposition and naming conventions](#Test-disposition-and-naming-conventions)
4. [Nulltests for constructors](#Nulltests-for-constructors)
5. [Public, internal and private methods](#Public,-internal-and-private-methods)
6. [Naming conventions for test projects](#Naming-conventions-for-test-projects)
7. [Unit test documentation](#Unit-test-documentation)
8. [The Arrange, Act & Assert pattern](#The-Arrange,-Act-&-Assert-pattern)
9. [Repeatability and testing order](#Repeatability-and-testing-order)
10. [Assert](#Assert)
11. [One test per test](#One-test-per-test)
12. [Attribute usage](#Attribute-usage)
13. [Parameterised tests](#Parameterised-tests)
14. [Test driven development](#Test-driven-development)
15. [Generate a code coverage report](#Generate-a-code-coverage-report)

## Introduction
This document introduces general principles that should be followed when implementing unit tests. If a test has a dependency to any external resources, such as databases or configuration files, they are considered integration tests and not unit tests. Currently there is no document that describe the process for implementing integration tests.

The testing framework that the project uses for unit tests is [NUnit]. [NSubstitute] is used as a mock-framework.

## Test delimitation
The unit tests should only test the class for which they were written. Any other dependencies to other class should be achieved though mocked objects. The classes are written according to Dependency injection. This allow the mocked objects to be able to replace the proper objects. It also makes the code more modularised.

Dependency injection can be performed in two ways. Either though the constructor for a given class, or though modifying the properties of an object. In this project, we only allow the former.

It is not possible to mock a class. Instead one has to mock an interface that the class implements. Therefore, a class has to implement interfaces for every method that should be tested.

Example: The class Car has an instance of the class CarDoor. CarDoor in turn implements ICarDoor. The Constructor for Car then becomes:

```csharp
Public Car(ICarDoor carDoor)
```

## Test disposition and naming conventions
The Nunit framework has several tags that allows users to set up preconditions and perform clean up on their tests. Examples of such tags are [SetUp], [OneTimeSetUp], [TearDown] and [OneTimeTearDown]. The Setup and TearDown steps are performed each time a method that is marked with [Test] is executed. OneTimeSetup and OneTimeTearDown as performed once per [TestFixture] class.

It is advised to declare the class that you’re testing as an instance object and then instantiate it during the SetUp stage. Then the same object can be used for every method in the class. Using mocked objects is even better.

A test becomes more distinguishable if the author adds the suffix Mock, such as _dataAccessMock.

## Nulltests for constructors
One should aim to catch errors as early as possible. A good example of this is to implement null tests for constructors. For example it might be difficult to spot errors in a rarely used class. The errors might even be detected long after the class has been pushed into production. If null tests are present, errors can generally be caught much earlier during the development process.

## Public, internal and private methods

A unit test will only test public methods. It is also possible to test internal methods by setting the testing assembly to *friendly assembly* on the assembly that is about to be tested. Private methods should be tested though invocations within public methods.

If it is not possible to achieve full code coverage though only public and internal methods it means that the code within the private methods are not being executed.

If there exists a public method that invokes the private method, a new test should be written for the public method. This will then cover the previously untested private method. If the private method is not invoked by a public method in any way it is most likely dead code and should be removed.

## Naming conventions for test projects

Each test project should be a Visual Studio project. The test projects should all have the prefix UnitTest, such as UnitTestBusinessLayer. Each test project should be situated at the same level in the folder structure as the project that the test project is testing.

## Unit test documentation

The unit tests specify how the code should behave under certain circumstances. The unit tests are such an important aspect of the documentation for the code that is being tested. Therefore it is important that it is clear and precise what a specific unit test does.

In this project we are applying the naming convention [UnitOfWork_StateUnderTest_ExpectedBehaviour]. Follow the four steps described below when documenting a new unit test.

1. *UnitOfWork* should be set to the name of the method that is being tested.
2. *StateUnderTest* should describe that is being tested.
3. *ExpectedBehaviour* should describe the expected result or behaviour of the test.
4. If it is not obvious what the testis testing then a comment should be written along with the test. This comment should explain what the code does and what is being tested.

Example:
```csharp
[Test]
public void Multiply_2by3_Returns6()
{
   // Arrange (nothing to arrange in this test)

   // Act
   int result = Multiply(2, 3);

   // Assert
   Assert.That(result, Is.EqualTo(6));
}
```

## The Arrange, Act & Assert pattern

The AAA pattern should be used when writing new unit tests. During the act step, the prerequisites for the test are set up. Then, during the second step, the test is performed. Finally, the result is evaluated in the third step. See the example in the section above.

## Repeatability and testing order

The unit tests should always give the same results no matter which order they were executed in. The following are examples of things that should be avoided.
1. The tests should not use different data each execution. For example using DateTime.Now() would be a bad choice.
2. The tests should not used Thread.Sleep() in order to let the classes finish their tasks.
3. The tests should not be dependent on random functions.

## Assert

The constraint based Assert model (Assert.That) should always be used. There is a chance that the parameters get mixed up if Assert.AreEqual is used instead.
```csharp
Assert.That(serviceString, Is.EqualTo(”DBCImporter”));
Assert.That(serviceString, Has.Property(“Version”).EqualTo(2));
Assert.That(serviceString, Is.EqualTo(”DBCImporter”, “DBCImporter is wrong.”));
```

## One test per test

Only one thing should be tested during a single test. If we for example assume that we have a class that contains a stack and two methods, Store and Fetch. Where Store adds an object to the stack and Fetch gets the top object from the stack. An easy way to write a test for this would be to first add an object using the Store method and then fetch the same object using the Fetch method. Then evaluate that the returned object is the same object that was sent as a parameter to Store.

The problem here lies in that you will not find out what will happen if you, for example, were to invoke Fetch again. It is possible that Fetch might return the same number once more. A better approach to this is to populate the stack though dependency injection and then write separate tests for both methods.

## Attribute usage

Some tests use multiple attributes. For example the [Ignore] attribute along with the regular [Test] attribute. It is okay to put multiple attributes on the same row as long as it does not affect the readability of the test.

To prevent a test from being executed one can add the attributes [Ignore] or [Explicit] to it. If you for example have a test that is failing that you plan on fixing at a later time, you can add the [Ignore] attribute.

The [Explicit] attribute makes it so that the test will only be executed if the user selects that test manually. And then invokes that test only with NUnit. If you for example have a test that is failing and there is no plans to fix it, but it might be good to keep around for documentation purposes, the [Explicit] attribute may be used.

## Parameterised tests

The [Value or TestCase attributes] may be used in order to execute a single test multiple times with different input. There are two main advantages of this. The first one is that you will have to write less code and that each test runs separately. If we instead had looped over a range of values, and somewhere within that loop a test failed, the test execution would have been interrupted and we would have never found out if the remaining inputs would have passed their tests or not.

Example usage of the Value attribute:
```csharp
[TestCase(12,3,4)]
[TestCase(12,2,6)]
[TestCase(12,4,3)]
public void DivsionOperator_ParameterizedInput_CorrectResult(int n, int d, int q)
{
  Assert.That( q, Is.EqualTo(n / d), ”q is not equal to n/d” );
}

[Test]
public void UnitOfWork_StateUnderTest_ExpectedBehavior _(
    [Values(1,2,3)] int x,
    [Values("A","B")] string s)
{
    ...
}

```

Example usage for NSubstitute:
```csharp
[Test]
 public void ReadFpcs_ValidRequest_OneFpcIsReturned()
 {
     // Arrange
     const string ValidPath = "validPath";

     var sopsReaderStub = Substitute.For<ISopsReader>();
     sopsReaderStub.ReadFpcs(ValidPath).Returns(new List<Fpc> { new Fpc () });
     var req = new ReadFpcsRequestDTO
     {
         Path = ValidPath,
     };

     var sut = new SopsFileReaderService(sopsReaderStub);

     // Act
     var resp = sut.ReadFpcs(req);

     // Assert
     Assert.That(resp.Fpcs.Count(), Is.EqualTo(1), "Expected that exactly one fpc should be returned");
 }

```

## Test driven development

When working test driven one has to first create a test case before adding any new or changing already existing code.

How to work test driven.
1. Add a new test.
2. Run all tests and see if the new test fails.
3. Write code.
4. Run all tests again and see if the new code pass. If it failed, go back to step 3.
5. Refactor code.
6. Repeat.


## Generate a code coverage report

In order to analyse the coverage of different parts of the codebase one can generate a code coverage report. This task, however, takes a while to perform and it generates a large volume of files (roughly 400MB). Therefore it is not ideal to generate a new report upon every commit. However, it is easy to generate a local coverage report by following the steps in this section.

First, navigate to the root directory for the project. Create a temporary directory here. It is suggested to name the directory CoverageReport, as git will ignore a folder with this name.

```shell
cd /Path/To/Project/Directory/
mkdir CoverageReport
```

Then, run the tests and calculate the coverage with [Open Cover].

```shell
.\packages\OpenCover.4.7.922\tools\OpenCover.Console.exe -target:.\packages\NUnit.ConsoleRunner.3.10.0\tools\nunit3-console.exe -targetargs:.\SesammTool2.sln -register:user -output:.\CoverageReport\OpenCoverOut.xml
```

Finally, use the output file from the previous step to generate a coverage report with [Report Generator].

```shell
.\packages\ReportGenerator.4.5.6\tools\net47\ReportGenerator.exe -reports:.\CoverageReport\OpenCoverOut.xml -targetdir:.\CoverageReport\ -verbosity:Off
```

A report has now be generated. It can be viewed by opening:

```shell
.\CoverageReport\index.htm
```

[NUnit]: https://nunit.org/
[NSubstitute]: https://nsubstitute.github.io/
[UnitOfWork_StateUnderTest_ExpectedBehaviour]: https://osherove.com/blog/2005/4/3/naming-standards-for-unit-tests.html
[Value or TestCase attributes]: https://github.com/nunit/docs/wiki/NUnit-Documentation
[Open Cover]: https://github.com/OpenCover/opencover
[Report Generator]: https://github.com/danielpalme/ReportGenerator
