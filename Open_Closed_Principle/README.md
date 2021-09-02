# Open Closed Principle

# Transcript of the video

Hello everyone, in this video we'll see about open closed principle.
This is one among the SOLID design principle.
What is open closed principle? Basically its states software entities like classes, module function etc should be open for extension but closed for modification.
In simple terms, software entities like class, modules, functions etc should be able to extend a class behaviour without modifying it.
I've highlighted the keyword here EXTEND.
Let us look at a real world example of open closed principle. Then we can see the software representation.
Imagine a big building where we have a security desk at the entrance.
We ask him to register the details about guest who shows up.
So when a guest arrive at the desk, he should ask.
The name, contact number and the host information.
All good, the security infrastructure that we created starts to work now.
Now, one fine day, a service person shows up the desk. He doesn't look like a guest.
The security comes to you and ask about the instruction on how to handle the service person.
You give him a set of questions to ask for.
Again, the security infrastructure continues to work after this change.
All fine now one day a Driver, shows up at the desk and our security guard comes back to you and ask how to handle a driver. He is neither a guest nor service person.
You again give him a set of questions.
You can see where we're going with this now. For every new kind of person, our system needs a modification.
And in a big building we will have different kind of people showing up at the desk.
We need a system that can be extended without modification.
Let's make our system open for extension and closed for modification.
But how?
In such scenarios, we often look at the behavior and create some abstraction.
In this case also, let's see if we can find an abstraction.
We look at the different people visiting the desk.
And we create an abstraction called Visitor.
To a visitor, we ask some standard set of information.
Name and contact info and purpose of the visitor and name contact info of the host.
Now this system is open for extension and closed for modification.
When a new kind of visitor, like for example an astronaut, shows up at the desk, it still works.
This happens in the real world.
Object oriented software design picks up a lot from things in the real world.
When we create our software solution, it is better to create system that is open for extension and closed for modification.
Let's look at this software version of the same.
Okay, let's look at the code now.
We're going to look at the code in three steps.
First of the base system that we create.
Then a system that is close for extension and open for modification for every change then in the step three, we will try to create the system which is open for extension and closed for modification.
Okay, let's have a look at our code base now. So we have basically three important classes now, the guest and then security desk and our program.
Let's look at guest now.
Guest it's a very simple class, so guest has a name, a contact number, then the guest also provide the information regarding the host name and host contact number.
Then we have a security desk, a security desk has a name of itself then.
A security desk has one method called register.
Basically, if you give a guest then.
A security writes in a log book that this particular person with this contact number came to meet this particular host with this contact number.
Let's look at the program.
So in the program class we have a security desk at the maingate and then 2 guests visiting the maingate.
All looks fine.
Let's run the code.
You can see the security has entered the detail John Doe with this particular information came to meet this person. Jane Doe with this information came to meet this person.
All simple, fine, everything works, no issue.
Now let's go to the next version.
Let me switch to the other one.
Now let's look at our class again.
So we have our guest, but we have two new kind of people who are visiting the desk. One is the driver, other one is a service person.
Now let's look at the implementation of those classes.
A driver again has a name, contact number has a host name and contact number and also a vehicle number. Because the driver has to drive a particular vehicle so he also has a vehicle number.
And when it comes to service person you have for example name contact number who is the host and who is the host contact number and also a service information. For example if somebody is going to service, let us say water cooler. So he would have the information regarding the ticket and all those details.
Now let's look at our program.
So in the program, if you see.
We can create a security desk.
We pass for example two of our guest and then we also pass a service person and driver. So now our security desk has to handle all these different kind of people. So what do we do in the service desk?
Let us go to the security desk. Now you can see in the security desk.
We have to add one method for every kind of person. So for service person we have a method, register, service person and for driver we have one method called register driver. So every time when a new kind of person comes visiting the desk. Then this security desk has to be modified.
Let's run the code again.
With the new set of guest now.
You can see.
The two old guest were handled and the new guest. For example, the service person who came to service the printer was also registered and then the person who came to pick up and drive a car also was registered by the service desk. You can see this particular class is now open for modification and closed for extension. So whenever a new set of person visit the desk. The security desk class has to be modified.
This is what we want to avoid in the open close principle. Let us see how do we make this in line with.
Open close principle now.
Let me switch to the main one.
What we do like in our real world, we create an abstraction called visitor again. We are not going to use an implementation inheritance here. We are going to use a behavioral inheritance because in implementation inheritance, at times can get really complicated. It is always better to use a behaviour inheritance. So in case of visitor.
I define interface which says visitor should be able to provide the name, contact number, host name, host contact number and the purpose.
Now let's see how do we implement this in each of the classes. Let's take a first class which is guest. So in guest we have name, contact number, host, host, contact number. Everything is fine, but we have this purpose.
So basically we say the person has come for some meeting.
Let's see what happens in the case of driver.
In case of driver we say the purpose is driving this vehicle number.
And in case of service person if you see we say the service person has come for servicing this particular service info.
Now let us see our security desk now.
The security desk now has become much simpler.
Because now this class need not be modified for every kind of visitor. Basically we ask the same standard set of questions to all the visitor and then we make an entry in a uniform way. So when you say register, we ask the person name, contact number and then came to meet this host with this contact number and for this purpose.
Now let's look at our program. So the programs remains the same. I have not changed anything in the program. We create a security desk. We have two guest, a service person and driver.
Let's run this code now.
you can see.
The program was able to handle all the cases.
The two guest and also the service person and the driver. So this is an example of how you can create a solution which is open for extension and closed for modification.
So whenever you do your implementation, you will always have this.
Option where you can create something which is Open for modification closed for extension or open for extension closed for modification.
It's always better to choose the later one where you follow OCP. It will really make your systems simple and also testable, and also it will make some part of your code more stable and the new code will always be a separate one and it will not really create any changes in your existing codebase. Another thing which I would like to emphasise is always try to use a behaviour based Inheritance rather than an implementation based inheritance.
Thanks for the attention. See you in some other video.