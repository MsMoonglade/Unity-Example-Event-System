Project to see my Event Manager in action.

In Demo Scene EventManager Object have the EventManaher Class.
The other Classes that want to subscribe/launch events use this class.

In Asset/Scripts/Event the "Event" Script is used as a reference to simplify calls and reduce possible string spelling errors.

With this Event Manager you can call events both with and without passing variables.

The Tester object is used to test an event without parameters and one with a parameter, in the OnEnable of the object it subscribes to the different events.

Input Manager object detect Keyboard Input and call the respective event.
