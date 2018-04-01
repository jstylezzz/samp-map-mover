# SA-MP Map Mover
This tool allows you to move complete maps from one place to another. Please note that this tool has been kept as simple as possible and only does what's essential for the process of moving a map.


# Usage

In the left box paste your existing map code. The mover currently accepts **one object per line**, in ***CreateObject*** format.

In the middle section of the program, enter desired parameters. The **Move X**,  **Move Y** and **Move Z** parameters basically push the map in that direction by giving units. **InteriorID** and **Virtual World** allow you to stream the map in a specific *Virtual World* or *Interior*. The **Stream Distance** parameter specifies the distance at which objects can be seen. This will be applied to all objects in the map.

Once you have that set, simply click the **Move Map Objects** button. If the map code from the *Original Map Code* box is correct, your code will be converted to *CreateDynamicObject* code for use with *Incognito's Streamer*. To make life easier, you can simply click the **Copy To Clipboard** button above the *Moved Map Code* box, to copy all converted code to your clipboard.
