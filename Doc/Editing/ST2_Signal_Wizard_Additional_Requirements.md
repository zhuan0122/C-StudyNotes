## Requirements for CAN Signal Wizard 
### As described in meeting with Jesper and Staffan on 2020-03-02 

##### Calculation of values in Signal fields:

* The fields Size, min, max, scale factor and offset should relate to one another as in SesammTool1.
* It should be possible to overwrite the calculated values as in SesammTool1.

##### Mandatory attributes
*  Only the attributes Name and Fullname should be mandatory (clarification of ST2-1589). 
* The undefined value should be used, for the values that are specified as required in the database. This is a consequence from ST2-1589 with current database design.

##### Attribute types
* The attribute types should be according to CR ST2_1589 (probably not a new requirement but a clarification)

##### Units
* The unit for the attribute should be included in label e.g. Size(bits) when available.

##### Initial value
- HEX value should be allowed

##### Enumerated fields
- Grey cross button should be removed and undefined used.

##### Field order
The order should be 
*  Name
* Fullname
* Unit
* Signal Value Type
* Data Type
* Byte Order
* Size
* Formula Factor
* Formula Offset
* Min
* Max
* Initial Value
* SPN
* Note
* Comment

##### Selecting signal to start from
- The create CAN signal wizard should have a selector for another already existing signal.  
- If a signal is selected then the values of the attributes of the selected Signal and its Values shall be copied across to the newly created signal as prefilled values. 

##### Value tables
- ValueTable and its values should not be visible in the left-side navigation panel.
- The Signal and value table dialouge should be modified with the buttons save/cancel/next/previous.
