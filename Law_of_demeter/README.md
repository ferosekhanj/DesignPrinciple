# Law Of Demeter (Principle of Least Knowledge)
## Transcript for the video

Hello everyone, welcome to another video. In this video we will look at law of Demeter, also called as principal of least knowledge.
What is law of Demeter? It states the method of an object should invoke only the methods of the following kind of objects.
Itself.
Its parameters.
Any object it creates or instantiates 
Its direct component objects.
In simple terms, each unit should only talk to its friends,Don't talk to strangers.
Basically, avoid calls like this.
Sometimes the same code can be rewritten as.
Like this, this is hard to spot.
But still, this is a violation of the law.
We have some exceptions like this. If it is about pure data access without any behavior, it is ok to some extent.
I would say even here you think why you need an information so deep in the hierarchy?
Another exception is Fluent APIs, even though it looks like a violation of law of Demeter here, the Fluent APIs often return the same object back as a convenience, and we are using the same object again and again, so this is not a violation of the law.
Let's look at a real world example.
Imagine a family going to some fair.
A father mother and child.
There's a balloon seller.
He wants to make some money.
He sees the child and gets an idea.
Attempt to sell that balloon directly to the small child by tempting the child.
This is an example where law of Demeter is broken because instead of talking to the parents, he's trying to talk to the child and sell the balloon.
Naturally, the parents blocked access to the child.
Now he does the right thing of selling the balloons to the parents.
We have so many examples like this in real world.
Let's look at the same situation in software.
Okay, so we are going to create the same thing in software now.
So let us see.
Let's look at the hierarchy.
So we have 2 important classes. One is the family which is part of the familyandfriends package and we have seller who comes from the stranger package now we have 2 utility data classes which is address and name which represents pure data and no behaviour and we have our program.
Let's look at the code.
Let's start from data classes.
So we have address which purely represents the address of a location then 
we have name which represents the name, first name and family name.
And then we have the family class where we have the name of the parents, their address, and how much money they have.
we have our constructor, then we have one method called requestpayment.
This is where the sale happens. So if somebody tries to sell an item.
With a price, the family checks if the item is the red balloon and if the price is less than 15, then they have enough money to buy this item, then they will say just buy it so they give the money to the requesting client if not reject the offer actually.
Let's look at the sellar now.
Seller has an item and price.
We have the constructor then.
This is the important method in seller where he if there's a visiting family he tries to sell the item to the family so the. If the family buys this item, then he Prints the bill. If not, he just wishes them well and then moves on.
And if you look at the sell item method, the sell item method typically.
Calls the RequestPayment from the Family and then provide the item and price. If the family agrees and pays the price. Then the sale is done. If not, the sale didn't happen.
And we have 2 utility methods for printing the details.
Let's look at the program now.
So in the program we create a family.
Some John Doe and Jane Doe.
And there are 2 sellers now. So we have Seller s1 and we have seller s2  Seller s1 sells red balloons for 10 bucks while seller s2 sells.
Red balloon for 20 bucks now both tries to sell the object to the Family.
So.
Let's run the code.
You can see.
The first seller tries to sell the balloon for 10 bucks the sale went through he prints the bill and then the second seller also try to sell the balloons for 20 bucks. And then the family rejected it. You can see he prints wish and then it's the ends.
Now let us look at the updated version where we want to bring in the child into this code.
Now we have 2 additional classes actually one class and one interface.
So we have a child.
So the child has basically the name of the child and then the family the child is attached to.
And Child has one method called Tempt. So basically you can.
Give an item and you can give a price and then you can tempt the child to buy it. You can see already visual studio mark this as grey because this item is not being used.
So the child is not bothered about, say the price. It only want this item and it's not really using it internally.
Now let us see how family has changed now. So in the family we try to bring in the child now. So we create a list of child as children.
Naturally, whenever we create some data inside a class, we try to also expose that as.
A property So this is the first step where.
The law of Demeter can be broken because when you expose something then.
Somebody can really misuse that in this case. For example, the author says.
He's exposing the child as a read only list so that somebody cannot really change the number of children. or the children object inside the family, so he tries to protect it. And in addition to that.
He also now creates a family interface so that he doesn't expose the entire family methods to the external clients, and in addition to this, now we have an internal request payment method. This method does not have anything. Basically, if you ask for some money if the family has the money then family will give this money back to you. As simple as that. Who is using this? it is a child.
Who has this privilege. So basically child can go and ask. I need this money, you give me the money and then family will give the money to the child. Let's look at the family customer.
So the interface. So we have created a family customer interface where we clearly say somebody external can access the father name, mother name, address and the.
Children property and if you want to sell something, you can use this request payment method.
So the other internal method is not exposed as a part of the interface.
Now let us go to the seller. You can see the seller is still the same. Nothing has changed here.
Let's see how we can break the law of Demeter here. So instead of asking the family for the.
Payment and try to sell the family. I try to sell this to the child so I look at the child.
Take the zeroth instance and then tempt the child to buy this item.
So for the seller, still the logic works through because.
He asked the child to buy this item. He names the item and price. Child Ask the family for the price.
Family again.
If you look at the request payment gives the money whatever the child is requesting for. So basically seller.
Achieved whatever he want.
Now let's run this program.
You can see the first seller who was selling the balloon for 10. He was able to make a sale now.
and the second seller who was selling the balloon for 20 is also able to make a sale now.
Both went through.
Now if you look at the seller class.
It is deeply coupled with the family implementation. Even though we say I have IFamily cast, we are depending on the Ifamilycustomer interface, but we already assume that, for example, a family customer will have one children and the children have tempt and then we try to really go deep inside and then get this thing done.
Even though this is possible. Don't do Such a thing because overtime when you want to refactor and maintain your class implementation, it will be really hard. That's why they call this as law of Demeter. Something is possible, but then by Law we are prohibited from doing such things. So here also, even though it is possible to do, do not do.
Such an implementation if you really need something like this, if you want to really tempt you ask the family implementation for tempt method. You can say can I really tempt the family if they say no then it's not something which you are supposed to use in your code.
Thanks for the attention. See you in some other video.