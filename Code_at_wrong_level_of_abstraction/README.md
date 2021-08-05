# Code At The Wrong Level Of Abstraction

## Transcript for the video.

Welcome to yet another video. In this video I'm going to explain about code at the wrong level of abstraction.
What is code at wrong level of abstraction? It means we should separate the higher level general concepts from the lower level implementation concepts.
If you mix them up, then your abstraction can become meaningless after some time.
But before. Before that, let us see what is an abstraction.
As per Grady Booch, an abstraction denotes the essential characteristics of an object.That distinguish it from all other kinds of objects and thus provide crisply defined conceptual boundaries relative to the perspective of the viewer.
I've highlighted the important words here "Conceptual boundaries". Identifying conceptual boundary is a very important step.
Let us look at some fictional printer software development.
We are going to see how code at the wrong level of abstraction enters our system and how it evolves overtime.
Let's look at an example. So the requirement states.
We are entering printer market with a new printer.
Users can use this printer for Home Office. 
It uses dot matrix printing technology. 
Users have to buy ribbon cartridges as consumable.
We need to develop the printer driver.
Printer Driver Team creates an IPrinter interface like this.
The interface abstracts printer in general.
It looks good.
Let's look at the code.
The dot matrix class implements this IPrinter interface and then basically all looks fine. Everything is straight forward here and Printer Driver class uses IPrinter interface here. So printer driver and dot matrix printer are loosely coupled.
And IPrinter interface represents a printer in general.
Let's look at the new set of requirements.
So we hear lot of feedback from users about the cartridge exhaustion error.
So we would like to give a notification to users that cartridge is empty.
Basically, user wants to know when the cartridge is empty so that he can replace it and avoid the printer error.
Now we add IsCartridgeEmpty method to dot matrix printer and straight forward implementation you can see IsCartridgeEmpty. 
So we have one ribbon cartridge we check is empty and then we just return the status.
Now driver doesn't know Dot matrix printer. 
It knows only IPrinter. So we add this IsCartridgeEmpty method to the IPrinter interface itself.
As I said before, this brings in some assumption into our IPrinter abstractions.
They are.
A printer will have a cartridge and the cartridge can be empty.
This is an example of code at the wrong level of abstraction, because the concept of a cartridge is specific to only, a subset of printers and we are mixing this with generic IPrinter interface.
These kind of things happen. For example, the printer driver is written by a different team and printer firmware is written by a different team and teams at times solve the problem with minimal change without considering the consequence. Let's see what happens in the upcoming releases.
So now.
We are adding a new printer to our product line. 
It is based on inkjet technology. 
Uses have to buy colour and black cartridges 
since time to market is very important. 
We will reuse the printer. 
We will reuse the driver with minimal changes.
Since we are reusing the driver, the inkjet developers while implementing IsCartridgeEmpty ends up in dilemma.
Because there are 2 cartridges.
To be on the safer side, they decide a cartridge is empty when either one is empty.
In the end, user gets annoyed because even if the colour cartridge is empty, the printer can still print in black and white.
But our software implementation blocks that.
You can feel something is wrong here.
Let's look at the next set of requirements. 
We are adding a new printer to our product line.
This is for our volume customers.
Users have to refill the ink tank.
Again, time to market is important. We will reuse the driver with minimal changes.
Ink tank printer doesn't have any cartridges now.
The printer cannot find when the tank is empty.
Now our IsCartridgeEmpty method has to handle this scenario.
Again, the InkTank team makes a work around. Assume tank is full always, but this is wrong. The tank can become empty. We don't have a mechanism to find out.
You can see how mixing up the abstraction made the IPrinter a mess now.
This is a simple example. In real world it may be even more complicated, so be careful about your abstraction.
Avoid code at wrong level of abstractions.
Thanks for the time. See you in some other video.
