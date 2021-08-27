# Liskove Substitution Principle

## Transcript 

Hello everyone, in this video we'll see one of the solid design principle liskov substitution principle.
So what is liskov substitution principle?
The formal definition is if S is a sub type of T then objects of type T may be replaced with objects of type S. In simple terms, functions that use pointers are references to base class must be able to use objects of derived classes without knowing it.
What should derived or subtypes adhrere to?
Basically two things, function signature and behaviour conditions as a part of function signature, you can send the derived object where base is expected. Similarly, you can return derived object where base is expected. This is called Contravariance and covariance in short.
You can read up more on this Internet also if your function signature includes exception then you cannot throw different exception. At the most you can throw at derived exception.
As a part of behaviour, you cannot make the preconditions strong and post conditions weak.
Also, the invariants must be preserved.
In addition to this, if there are any historical assumptions.
Then the derived type cannot break them.
I'm not going to explain this thing in full here. It will become too much theory. You can read up the theory in Internet, are textbook, but let us look at a real world example.
Imagine a school management system school that has some actors like teaching staff, cleaning staff and security staff.
Each of the staff can access these school facilities like library, classroom and canteen.
Let us consider some use cases here.
The library and classroom logs the user entry and exit information using ID card.
They can buy food items in the canteen and the amount is charged to the user ID card.
Now we have a new actor called visiting staff who also needs access to this facilities here.
But the visiting staff cannot access any of these things as of now, so let us see how do we handle such a scenario in the real world?
One way is to bring in a change in the system.
That means in library, classroom, canteen and handle.
This special case.
But this is very hard. Each department has its own rules.
And breaking them and then reimplementing will be costly. Another option would be.
We link the visiting staff to an existing staff, but we cannot send the regular staff for such a work.
It will disrupt the regular work.
Let's try another option now.
We give a visitor ID card.
This card works in all over systems and the visitor can independently access the facilities.
The problem is solved without modifying our entire system. You can see until the visitor didn't abide by the rules of being a staff. The visitor couldn't be accommodated in our system. When you say the visitor is staff, the visitor should have the access card. This is an exception assumption about staff in our system.
We cannot break it. This is what is stated in LSP principle.
When you classify an object as a kind of an abstraction, the object should abide by all the rules of the abstraction.
Now let's do. Let's try to implement this in software. We see our system actors have some common traits.
We try to identify.
That here.
Let's call it as staff.
We have three concrete implementation teacher cleaner and security.
We assume as staff will have name role.
Whether active or not, enter some entry and exit log.
And accept some expense charges.
And we create our systems around this abstraction.
The system can be expanded without modifying it.
This what we called as open closed principle.
Let's look at the code.
And the initial version.
Here is the software example.
Let us look at the code base.
So basically I am trying to implement the same thing in code.
So we have our system which contains.
For example, canteen classroom library, the facilities then we have a staff, a staff card.
Then we have three actors.
Cleaner security and teacher who are inheriting from staff.
Let us look at the code.
So let's start from the basic abstraction staff.
So a staff has name.
Roll number.
Then is active.
We provide methods for logging the entry and exit. Pretty straight forward things and one method which is to charge expense. This we want the derived class to implement.
On basically this method you can see we just give amount and we expect this method to charge. We do not want any bool or anything where we say charging fail nothing like that. If I say the amount to be charged it should be charged.
Then we have.
Let us take the facility so you can see library has enter exit methods here. I'm not implementing everything for the sake of explanation simplicity only the extension method I have implemented. So entry and exit logs are entered here. If look at the classroom. Again similar methods are there canteen has a method to charge the staff. So if you give a staff and then amount then typically it will check if the staff is active and then will make a charge to the stuff.
Let all simple things. Now let us look at one of the actors so you can see.
We have a teacher class which inherits from staff and we have the name and an ID card which is provided to the teacher, so we take some of the information from the ID card, like roll number and is active, and other information like name. We store directly here.
And we provide the implementation for charge expense, where we take the amount and then we add the amount of debt inside our card. More or less all are similar, nothing much.
Let's look at the program class.
So we create a set of staff like one cleaner, one teacher and one security. Then we create a set of infrastructure like canteen, classroom, library and then we try to.
Use them and see what happens.
Let's run the code.
We can see each once.
Card is being charged for the expense. Entry information is logged. Exit information is logged. Everything works fine.
Now we have our scenario. A new entrant called Visitor in our system.
How to include the visitor in our solution? Either change the system to handle the visitor as a special case that means modify classroom library and canteen, but this will break OCP and also when you want to add further things you need more such modification. This can create the code a bit complicated or make the visitor as a kind of staff.
Let's look at the first version that breaks LSP.
Now let's look into the scenario of visitor.
You can see we have a visitor class here.
In our actors.
Now let's see the implementation for visitor.
So as I said before one way to include the visitor in our system is to go and change, for example this infrastructure classes take for example, in canteen you come and then here you check or you provide one more method which says charge visitor and then you add the implementation there and go to classroom and then here
visitor enter and visitor exit things like that. This things will really make this class more verbose and more complicated. So what we say, let us make visitors staff and we treat him as a staff so that visitor is a staff and then let's try to implement. You can see here we are saying we don't know there's no roll number for a visitor right? Because the visitor comes temporary is not a permanent member. So we try to give something like -1.
And then we say visit is always active, so we don't say which has any issue. Name of visitor is fine, we get the name of the visitor and when you want to implement charge expense we can clearly see we dont have any means to charge the visitor because.
We don't have a card. We don't have a means and we say visitor couldn't be charged here, so now when you try to run this program, let's say.
It's running.
You can see all others are being charged, while when it comes to visitor I don't have any means to pay and similarly entry and exit works because those methods are implemented. But when it comes to payment we skipped this all together and then now we cannot really make a payment.
So this is a violation of Liskov substitution principle because.
We told that visitor is a staff, but then when implementing all the rules of staff, we are ignoring some particular things. Here we have weakned one of the OR say.
Method here where we provide no implementation or worst case. We can also throw some exception not implemented or not supported. Exception even that is a violation of liskov substitution principle.
Now let's ensure.
liskov substitution principle is adhere to and refactor the code.
And implement the visitor without breaking any assumptions from the staff.
So now If you see we want to really solve this problem, so we create a class called visitor card.
So the visitor card has a role number is active date something similar to the staff card? But normally what we do is a visitor card has a departmental id as roll number. So whenever a visitor is charged a department really picks up all this debt and then make the payment.
And also a visitor card is always active, it never goes out of active and also has a zero debt to start.
So we create a visitor card and then we change visitor class.
To take the visitor card now.
and we also provide proper information so you have a card. You take. The role number is active from the card and you receive the name and when charge expense is called for you, make a charge to the visitors card also now when you try to run the application.
Can see the visitor card was charged with ten and then the debt went to 10 naturally and visitors able to live inside our system without breaking any of the rules, so this is an example of how, for example.
Often liskov substitution principle if it is broken, what happens, and similarly if you adhere to the liskov substitution principle, then what happens whenever you design a system with a open closed principle where it is open for extension closed for modification you would definitely require to implement and Adhere to liskov substitution principle.
Thanks for the attention.
See you in some other video.