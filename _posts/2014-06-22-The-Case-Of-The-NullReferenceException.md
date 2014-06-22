The Case Of The NullReferenceEception
=====================================

As most developers, you might not be happy if a piece of your software throws an exception. Because then it is obvious that there is something wrong, something has be fixed. Assuming a reproducible failure condition, the case falls basically into two areas: either your code has a severe bug, or some component is just not called properly.

> **TODO**: Screenshot of exception in Visual Studio

In either case,

> The exception is your friend

At least, it tells you explicitly, that there is something to do.

Well and if something is wrong in our system, we should be more than happy to hear about it. Unmistakably and fast. We will not want to have exception-suckers, that leave us in a false sense of happiness, until the failure condition causes a maybe much bigger problem elsewhere.

# Infamous Quote From A StackTrace: "Object Instance Not Set To An Instance Of An Object"

An all too well known sign of missing to fail fast is the occurrence of a  **NullReferenceException**. 

Although it might be super-obvious to you, let's see what the reason is for a NullReferenceException.

## Reasons For A NullReferenceException

Let's recap some very basic stuff here, to get us all on the same page. 

Say we have a class `Person` with a property `Name`. A typical usage could look like this:

    var me = new Person();
	me.Name = "Paul";

Everything is easy and cozy. In the line `me.Name = "Paul";` we give a value to the name of the object `me`.

### But what is `me`?

`me` represents an object of type `Person`. The important thing is to be clear that `me` **is not** a person object by itself. Rather it **is a reference** to a person object.

Let's depict this with a little image:

![A object variable referencing an object](/images/posts/NullReferenceException/ReferenceType.PNG)
{: .image}

So now let's deconstruct the first line of our little code snippet from above. For the sake of clarity, let us implicitly declare the variable:

	Person me = new Person();

Now, these are the three parts:

### 1. Declaration

The left part of the statement means: We need a place to store a reference to an object of type `Person`:

    Person me ...

In the image above, this is just the little box:

![Declaration of a variable of type Person](/images/posts/NullReferenceException/Variable.PNG)
{: .image}


### 2. Allocation

The right part of the statement means: We need a new object of type `Person`:

    ... new Person()

Note that at this point, we have any property is in its initial state. For property `Name` let's assume that this is just an empty string:

![A new object of type Person](/images/posts/NullReferenceException/NewPerson.PNG)
{: .image}


### 3. Assignment

The connecting part of the former two is the assignment operator:

    ... = ...

This one sets the reference denoted with `me` to point to the new object of type `Person`:

![A new object of type Person and a referencing variable](/images/posts/NullReferenceException/NewPersonWithReferenceToIt.PNG)
{: .image}


(We've left out the semicolon as the last non-whitespace character from the complete statement up to now. For our purpose we consider it a syntactical necessity to conclude the statement.)

## The Real Thing

As you might have noticed, in my description and image of the part "1. Declaration", I have left out one vital thing: Where does a reference like `me` point to, if it is not part of an assignment of any kind? While a new operator without assignment or member call is not feasible on its own, a lonesome variable declaration is perfectly fine:

	Person me;

Well, after that declaration alone, the reference of `me` cannot be queried, it is undefined. Every access to it other than an assignment will result in a compiler error:

	Person me;

    var x = me;	      // Error: Use of unassigned local variable 'me'
    me.Name = "Paul"; // Error: Use of unassigned local variable 'me'

But what can we do if we know we need a variable later on, but are not ready to let it reference a concrete object? As we know, we will assign it to `null`:

	Person me = null;

    var x = me;	      // Compiles fine
    me.Name = "Paul"; // Compiles fine (but at runtime ...)

We can imagine this situation as a reference pointing to a commonly well known place for any reference variable, that has nothing to reference to:

![An object variable referencing null](/images/posts/NullReferenceException/ReferenceToNull.PNG)
{: .image}


If we run the code above, in the attempt to assign the value `"Paul"` to the property `Name` we get our beloved NullReferenceException:

![NullReferenceException](/images/posts/NullReferenceException/NullReferenceExceptionDialogVisualStudio.PNG)
{: .image}

 

--------------------------


constitutes three very distinct parts, that I want to relate to the picture upfront
Say you have variable `me` with the type of class `Person`:

    Person me;

And let's further assume that `Person` has a property `Name`.
If you see the symbol `me` somewhere in the code downstream, you can access it's property `name` using the dot-operator:

    ... = me.Name;

This is all fine as long as `me` has been set to a concrete object before, such as with

    me = new Person();

or

    me = members[0];

But what if `me` has not been initialized at all: 

    Person me;
    me.Name = "Paul";

or it has been explicitly set to `null` in between?

    Person me = new Person();
	...
	me = null;
	me.Name = "Paul";

In either case, the NullReferenceException gives you just a hint that there is something missing. Maybe it means that some object could not be found in a dictionary because of a wrong value for the key on lookup. The message of the Exception tells you exactly nothing more. If you are lucky, what might help you is the StackTrace. Poor you if the line the StackTrace points to contains several candidates as in:

    var data = x.GetData(y.Name, z);
    
In this line of code the reason for the NullReferenceException can be x or y being null. So you can guess. z can not be the canditate because it is perfectly fine to pass a null as a method parameter. If the NullReferenceException occurs in the method GetData(), the top of the stacktrace would not be the very line above.
That problem obviously occurs on the attempt to access a member of a reference variable that is null.

So what can you do:
Add a guard clause as early as possible: On method level or on class level (construction time).

- If the member access of the method parameter happens unconditionally, then the guard clause can be done right on top of the method body. If the reference in question is a passed as constructor parameter, this constructor is the first place where you can check if the parameter is not null.


NullReferenceException 
