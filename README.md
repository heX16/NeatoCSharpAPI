# Neato API
Interface that communicates with a Neato XV-15 through USB COM serial port. 

Should implement most of the methods outlined in the Programmer’s Manual (http://www.neatorobotics.com/programmers-manual) from Neato Robotics.
Unless otherwise noted, will use methods outlined for Neato firmware version 2.6.

## Setup
In order to access the Neato through this API, you will need to have installed the drivers available from Neato Robotics (used for their firmware upgrade tool). Once installed these will provide a COM port access to the Neato XV-15.