# Hidden Logical Dependencies

## Transcript for the video

Hello everyone.
I am restarting the series after a long break.
So this time, let's start with the design principle Hidden Logical Dependencies in software coding.
So what is Hidden logical dependencies?
It refers to a situation where the behaviour or outcome of a piece of code depends on conditions or inputs that are not readily apparent or explicitly communicated?
This differences can lead to confusion, unexpected behaviour.
Difficult to debug issues.
Understanding and managing hidden logical dependencies is crucial for writing clean, maintainable reliable code.
Lets also look at situation where this can happen.
There are few common scenarios where hidden logical dependencies can arise in software coding.
When a variables value is modified or accessed from multiple parts of the code base, it becomes difficult to track the flow of data and understand its impact on different functions or modules.
Changes to global variables can create hidden references that are not easily apparent, leading to unintended consequences.
In some cases, the order in which functions are executed can impact the overall behaviour of the code.
If this order is not explicitly communicated or documented.
Again, it can create hidden dependencies that are difficult to predict or maintain for the users.
Code that relies on specific input conditions without clearly specifying those assumptions can introduce hidden dependencies.
And the last one, the most trickiest one, code that relies on external resources or states, such as files, database or network connections can again create hidden dependencies.
And changes in these external states can impact the behaviour of the code and if dependencies are not well managed it can lead to issues like race conditions or inconsistent behaviour.
Let's look at a real world example.
In cars, there is a safety feature called child lock.
So when one activates the child lock, the door cannot be opened from inside.
This avoids the child from opening the door accidentally and creating any sort of trouble.
I call this hidden logical dependency because around the door lock, there is no indication that shows a childlock is active.
And while the door lock operation depends on it.
The first time adult users, can get confused, when the door doesn't open due to the child lock.
There is a moment of surprise.
In this case the hidden logical dependency is not detrimental. Maybe it is even intentional from the designers, since kids are very intelligent and can deactivate the child lock if it is very evident or visible to the child.
Now let's look at the software implementation of the same thing and see how we progress from
hidden logical dependency to making that explicit.
It's always the problem starts simple. In the iteration one we have a car with 4 doors.
The door has a lock.
It can be opened or closed.
And lets see the initial implementation.
So this is the initial code implementation so I have 2 classes for example Car.
It's a straight forward. For the sake of simplicity we are going to only concentrate on the doors part and we are going to implement only that requirement. So if you see a car has 4 doors.
And we also exposed Doors as a property because we can access the door from outside independently from the car actually. So 4 doors are created and then that's pretty much it in the car then.
We have the door class and if you see the door class is pretty straightforward. We have a state locked and then we have 2 operations.
Open and close.
And when you open the door for example the door is unlocked and when you close the door for example the door is locked. The program also I create a car class and then initially check the state of the lock and then try to open the door and then close the door. Now let us look at the outcome.
We can see initially the door is locked.
when you try to open the Door. It is unlocked and when you close the door it is locked again.
So nothing fancy, everything is fine.
In the new car.
We introduce a childlock feature in the iteration 2.
The childlock if enabled prevents the door from being opened from in the inside.
And now let's implement this requirement in our code and see how we are able to bring this new feature.
Again in the new implementation, for example, the car remains the same, it has same door.
But there are some changes in door.
So we bring in the child lock. So basically we added the child lock here and then in the constructor we also made for example the child lock is false.
And what we do, we bring in something like for example. Now the door can be opened from outside and also from inside, so we want to distinguish this feature. So in the open we add a bool which says we can open this door from inside actually and close remains the same.
Now let's look at the program itself. We try to.
Let's see, change the code here so the car remains the same. We initially try to open the door from outside.
And then close the door. And then we try to open the door from inside and close the door. Now let's run this program.
So this behaves as expected. You can see initially the door is locked. When you try to open it is unlocked, When you close, it is locked again, when you open from inside it is unlocked and when you close it is locked.
Now.
Let's enable this.
child lock here.
And then try to run the same code.
You can see now.
The door is initially locked. When you try to open the door from outside it was able to open, you lock it.
When you close it will get locked and but now this time if you see when you try to.
Open the door from inside.
It didn't unlock the door. Remains locked, actually.
So this is a moment of surprise for the consumer, mainly because if you see what?
The consumer will see.
In your code is like this.
So basically this is what the documentation they will typically see. So if for example if I opened this.
There is a door class and then it has locked child lock, open, close and there is a bool parameter here and if you see that documentation it says this is for door lock, this is for child lock. And then this method opens the door and there is only one parameter from inside and it says if you set this to true your opening from inside if you set this to false you are opening from outside and if you close it is supposed to close. So there is no indication that.
When I try to pass for example true here, suddenly it is refusing to open. So this is the moment of surprise for the consumers and this is the reason we called this as a hidden dependency because there is a dependency between this operation and child lock, but it is not evident, it is not explicitly communicated and for the user it really, what to say,
Brings in some kind of an annoyance.
So now let us see how we can really fix this issue.
So in order to fix this hidden logical dependencies.
There are multiple ways.
So one of the important thing is encapsulate code functionality into modular units.
With well defined interfaces.
And minimise the exposure of internal details.
This allows for clear separation of concerns and reduces the chances of hidden dependencies.
And clearly document assumptions, constraints and expected behaviours in code comment, API documentation, project documentation and explicitly communicate the dependencies and requirements of functions, modules or components to make them more transparent and understandable.
Always write the documentation from the perspective of the consumer.
Validate and sanitize input data to ensure that it meets the expected criteria. Provide meaningful error messages or feedback to users when input conditions are not met. I will say if possible, prefer immutable data and functional programming principles. This will reduce hidden dependencies by avoiding state mutation and side effects.
A function that always produces the same output given the same input, help eliminate hidden dependencies caused by mutable state.
And finally write scenario based unit test to validate their behaviour and functionality of individual coding.
By covering different scenarios and edge cases, unit test can act.
As a live documentation that shall avoid any hidden dependencies.
Now let's get back to the code and see how we can really fix the problem that we introduced.
Now let's try to fix this thing that we created in last iteration. So here what I have done.
Now since opening from inside and opening from outside are 2 distinctive operations. I made that explicit here. For example, in the Door class you can see now open from inside is there and open from outside is there.
And also since open from inside depends on the child lock, we take the child lock as a parameter. So if child lock is true then open from inside.
Will not open the car and if child lock is false then open from inside will unlock the car actually, and if you see the program now.
So basically we create the car, then we try to open the car from outside, then we close the door, then we again try to open the door from inside with the child lock and without the child lock. And now if you see things are much more evident for the consumer and when you try to run this code you can see.
Things are as expected. So so initially when you open the door outside it is unlocked, when you close it is locked and then when you open the car from inside with the child lock the door remains closed. And when you try to open the door from inside without child lock then it unlocks the door and finally when you close it lock the door actually, 
so here you can see there is no moment of surprise because the dependencies are very clear and very evident. First of all, outside opening the door from outside doesn't depend on any kind of or say and child lock, and also inside depends on the child lock and then the child lock has to be explicitly passed here.
I would say there is one more variant actually, which I would like to show, which is.
See the child lock? He is an attribute of the door at the end of the day, so.
If you take this as a parameter, this state has to be maintained somewhere outside, so it can again create some annoyance for the user. Because whether a child lock is enabled or disabled, a door can really maintain this state itself. So let us see another version.
So in the other version what we are trying to do is. So we again bring back the child lock state like how we did, but this time what we do we explicitly provide operations for activating and deactivating the child lock.
And when somebody calls this method, for example activate or deactivate, we also say what is the implication? So if somebody activate the child lock and then it says it will prevent the door from being opened from inside.
And when somebody tries to deactivate the child lock and it says it will allow the door to be opened from inside.
And for open method, again we have 2 different variations, one for open from inside and one for open from outside. And in open from inside we have clear indication that unless child lock is activated. So now again for example if you run the program, the program.
Is still the same. For example, we have a car, we try to open from outside, close it, then we activate the child lock, try to open from inside, we deactivate the child lock open from inside and then you try to close the car actually. So now if you see let me run it.
You can see initially the door is locked.
And when somebody tries to unlock the door from outside. It unlocks it. When somebody closes it, it locks it. When somebody activates the child lock, child lock is active and when somebody tries to open the door from inside with the child lock now it says locked true. That means its not unlocking the door. So when we deactivate the child lock and then again try to open from inside you can see it unlock the door and close like always closes the door actually. So this way if you see.
We can whatever was the hidden dependency, we can make it explicit and we can also ensure that it is evident for the user, because at the end of the day, when the user looks at the code, typically he sees only an interface like this and then
When finally somebody looks at for example the documentation, this is what they see
They see all the operations and then they see the documentation. Nobody gets to really look into the implementation actually. So you have to explicitly state what is the assumption and if some method is called or something, if it is given on some kind of a state. All those things are documented in a valid manner.
That's all for today.
Thanks for the attention. Let's catch up in another video.
Thanks.