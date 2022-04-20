# Object Oriented Programming and C# with Cats 😸

## Instructions

This repository contains challenges for you to undertake around Object-Oriented programming in C#. You can work on these challenges individually or in a pair.

(The instructions below assume you have got your laptop setup ready for running C# applications as per the Pre-Journey)

To get started you should "fork" this repository into your own Git account and then clone down to your machine.

Once cloned, you can run the tests by running:

```
dotnet restore
```

followed by 

```
dotnet test
```

You'll see that all the tests are currently failing. Your job is to one by one fix the failing tests.

If you are working in a pair, we recommend working on one person's machine during pairing, but once your session has ended send over the code to your pair so that you both have a copy.

## Some facts about your objects

The objects you'll be working with are all types of Cat

Here's some facts about Cats....

By definition the blueprint for ALL cats is that they can do the following things:

    * Eat
    * Sleep

They ALL have the following attributes:

    * A piece of data that says whether they are asleep or not 
    * An average height represented in centimetres
    * A piece of data that indicates their setting such as "domestic" or "wild"
    * ALL cats go to sleep exactly the same way

After a cat has eaten its food their reaction tends to differ between species:

    * 🦁 A Lion will let out a victorious roar
    * 🐆 A cheetah will let out a snoring sound as it becomes tired following a chase
    * 🐈 A domestic cat tends to let out a purring sound


🧐 As a bonus exercise some domestic cats will randomly let out a dismissive "It will do I suppose" comment following eating.

We've created an empty Cat interface and empty Cat abstract class to get you started. Your first task is to figure out what
things can be put in the interface and abstract class.

## Your solution should have...

* The usage of a C# interface

* The usage of a C# abstract class

* The usage of encapsulation, abstraction, polymorphism and inheritance
