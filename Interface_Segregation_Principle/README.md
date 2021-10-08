# Interface Segregation Principle

# Transcript of the video

Hello everyone.
In this video we will look at the interface segregation principle.
This is one among the SOLID design principles.
I took some time for this one.
Because I couldn't find a convincing real world example. At last I found one.
Let's move forward.
So what is interface segregation principle?
It states.
Client should not be forced to depend on methods interfaces that they do not use.
Important point is the perspective.
We are talking about the perspective of the client when we design something, there are two perspectives.
One is the designers perspective, which is the internal view and the other is the user or client perspective which is the external view.
Depending on your perspective, you may expect different things from the system.
lets look at two real world. Example one where we design based on the internal view on the other where we design based on the external views.
Imagine you are asked to develop a system for issuing passports.
And you being the desginer, look at the system from your point of view and see everyone as a passport applicant. This is more the internal view, so you are the passport officer and there are people who are coming to apply for passport.
You create one application form for all.
Everyone should fill this application form and submit that to the passport office.
lets look at the sample application.
You can see the applicant should carefully go through the application and fill only relevant sections. For example, if you are a minor or a kid, then you should fill in your parents passport info and you need not give the biometrics. If you are a senior citizen then you can skip the police verification and you can ask a passport to be sent via post. If you are government servant then.
You provide your service location and you also need to provide your permanent address. Things like this.
So when somebody starts to fill in, they have to really think through what are the relevant things and they have to fill in only the relevant sections.
It would have been easy if there are four different applications.
One for kids, one for the elderly, senior citizens, one for the regular, one for the government servants and the application. Ask only the relevant questions.
This is what we mean by interface segregation principle.
lets look at another example here, you are asked to design a system for the bank teller. This time the designer looks from the clients view and design system UC.
People who want to deposit cash.
People who want to withdraw cash. 
people who want to get a banker check. 
people who want to exchange cash.
All of them interact with the teller.
Now even though bank teller must fulfill all the request for each group you create separate form. For example, for the depositor you have a deposit slip for the withdrawal person there's a check.
For the banker check then there is a banker check application for cash change there is a cash change application.
And each client fills in the relevant information and uses the bank teller.
Serving only his request.
This is very important principle for every designer.
You segregated the interface based on the client.
That are going to use your system.
Your system success depends on the ease of use for your clients.
So now.
Let's look at the software version of the same.
Lets see structure first.
So basically here I have implemented both the bank and also the Passport use case that I mentioned before and I have a sample program just to see how the client will use the implementation that we are doing currently.
Let's look into the code detail. lets look at Passport officer class. If you look at the passport office class we can see.
Then we have three methods. Basically it says you can apply for passport, submit biometrics and collect acknowledgement.
And when you look at for example the passport application form.
It's similar to what I explained before, so thats the name, date of birth, place of birth, postal address, is minor, parent passport info, biometric required, is senior citizen, pretty much all the information is clubbed together in one one class here, so depending on the use case the client has to really set something up and then ignore somethings.
Let's see how this is being used in the program. So here if you look at the passport case for example, we are going to apply for kids passport.
So I say name is Khan and then I give the data birth isminor is true then okay, I'm a kid so I say parent passport is some information provide then is biometric required I will say false because kids we don't give biometrics initially and then government servants are going to say false. Then we say senior citizen is false then.
You don't know whether example police verification is needed or not. Then postal address you provide service location. So you often get confused.
What to set or not to set and how? What is a valid passport application form? This creates lot of confusion for the user. May be there some trial and error is required or you should provide some extensive documentation regarding how this class has to be used by the client.
And also when it comes to the passport office at last for example, since we are doing a kids passport, biometric submission is not required so you can see here we have said that to false. So just apply and collect acknowledgement is fine but you try to do this. May be the implementation may throw error or it may not do something or it can make a log or something. So you can clearly see this interface is.
Completely mixed up for all the clients together, which can create lot of hardship for the Users.
Now let's look at the bank teller case.
Let's assume if you see the bank teller also has pretty much all implementation so has a name as a constructor. Then deposit, withdraw, exchange cash and then get bankers check. So these are the implementation. But then if you see for each of this case we also segregate the interface so we have a deposit teller, withdrawal teller, exchange cash teller, bankers check Teller and if you take anyone example depositor so the deposit teller has one form which just takes.
The date of deposit. The account where you are doing the deposit and the amount.
And then it has only one method called deposit. It takes in opposite form.
Now if you look at the exchange Cash tellar then exchange Cashtellar just to take the date and since this is.
No account is needed, just one information. Basically, you just tell the amount and then you can exchange the cash and then get your cash back actually.
Withdrawal teller if you see it says what's the date of the bearer name whats account ID and then whats the amount and if you give the form then you can withdraw 
now if you see for example the usage for this system let me go off.
For example, we create a bank teller.
But then when somebody wants to use for eg deposit function, you can.
treat the teller as a deposit teller and then basically what you do. You say depositclerk.deposit, then give the deposit form and the same teller. For example when you want to do withdraw again, you treat him as withdraw teller and then you just create this withdrawal form and then you do withdrawal. So this is like very straight forward. The client is botehring only about the implementation that is relevant for his use case? And also there is less chance of error and confusion? And what's to say less documentation effort So this is what we call interface segregation principle. This is one of the important ones in the object oriented analysis and design. So the main thing is you should look your implementation from the perspective of the client and think what they would expect and if something looks to be confusing or something looks to be out of place then you have to really segregate them and then make things simple for them.
Thanks for the attention. See you in some other video.