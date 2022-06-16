
SesammTool2 Meta Model
===
##### ToC
- [SesammTool2 Meta Model](#sesammtool2-meta-model)
                - [ToC](#toc)
    - [Common properties](#common-properties)
        - [Unversioned properties](#unversioned-properties)
            - [ID](#id)
            - [Versioned properties](#versioned-properties)
                - [Name](#name)
                - [IsActive](#isactive)
            - [Derived Properties](#derived-properties)
                - [DisplayName](#displayname)
                - [ShortName](#shortname)
    - [Functional](#functional)
        - [Function Category](#function-category)
            - [Versioned Properties](#versioned-properties)
                - [English Definition](#english-definition)
                - [Swedish Definition](#swedish-definition)
                - [Swedish Name](#swedish-name)
        - [User Function](#user-function)
            - [Unversioned properties](#unversioned-properties)
                - [Function Category](#function-category)
            - [Versioned properties](#versioned-properties)
                - [English Definition](#english-definition)
                - [Swedish Definition](#swedish-definition)
                - [Swedish Name](#swedish-name)
                - [OAS FPC](#oas-fpc)
                - [Contact Person Service](#contact-person-service)
                - [Responsible Person](#responsible-person)
        - [Use Case](#use-case)
            - [Unversioned properties](#unversioned-properties)
                - [User Function](#user-function)
            - [Versioned properties](#versioned-properties)
                - [English Definition](#english-definition)
                - [Swedish Definition](#swedish-definition)
                - [Swedish Name](#swedish-name)
                - [OAS FPC](#oas-fpc)
        - [Scenario](#scenario)
            - [Unversioned properties](#unversioned-properties)
                - [Use Case](#use-case)
            - [Versioned properties](#versioned-properties)
                - [English Definition](#english-definition)
                - [Swedish Definition](#swedish-definition)
                - [Swedish Name](#swedish-name)
                - [OAS FPC](#oas-fpc)
                - [Valid Condition FPC](#valid-condition-fpc)
                - [Valid Condition Text](#valid-condition-text)
        - [Test Case](#test-case)
            - [Unversioned properties](#unversioned-properties)
            - [Versioned properties](#versioned-properties)
                - [Description](#description)
                - [Environment](#environment)
                - [FPC](#fpc)
                - [Status](#status)
                - [Test Type](#test-type)
    - [Logical](#logical)
        - [Allocation Element](#allocation-element)
            - [Unversioned properties](#unversioned-properties)
                - [Component Allocation](#component-allocation)
            - [Versioned properties](#versioned-properties)
                - [Description](#description)
                - [Documentation](#documentation)
        - [Allocation Element Port](#allocation-element-port)
            - [Unversioned properties](#unversioned-properties)
                - [Port Data](#port-data)
                - [Allocation Element](#allocation-element)
            - [Versioned properties](#versioned-properties)
                - [Direction](#direction)
        - [Port Data](#port-data)
            - [Derived Properties](#derived-properties)
                - [Segment Display Name](#segment-display-name)
    - [Physical](#physical)
        - [Component](#component)
            - [Unversioned properties](#unversioned-properties)
                - [Component code](#component-code)
            - [Versioned properties](#versioned-properties)
                - [Full Name](#full-name)
                - [Documentation](#documentation)
                - [Owner](#owner)
                - [Generation](#generation)
            - [Derived Properties](#derived-properties)
                - [Allocation Elements](#allocation-elements)
                - [Segments](#segments)
        - [Component Code](#component-code)
            - [Unversioned properties](#unversioned-properties)
            - [Versioned properties](#versioned-properties)
                - [Code](#code)
                - [Code Type](#code-type)
                - [Description](#description)
        - [Can Segment](#can-segment)
            - [Unversioned properties](#unversioned-properties)
            - [Versioned properties](#versioned-properties)
                - [Bandwidth](#bandwidth)
                - [Protocol](#protocol)
                - [IsPrimary](#isprimary)
        - [Can Address](#can-address)
            - [Versioned Properties](#versioned-properties)
                - [Address](#address)
                - [Full Name](#full-name)
        - [Component Code](#component-code)
            - [Unversioned properties](#unversioned-properties)
            - [Versioned properties](#versioned-properties)
                - [Code](#code)
                - [Code Type](#code-type)
                - [Description](#description)
        - [Gateway](#gateway)
            - [Unversioned properties](#unversioned-properties)
                - [Component](#component)
                - [Source Can Port Data](#source-can-port-data)
                - [Target Can Port Data](#target-can-port-data)
    - [Communication](#communication)
        - [Can Port Data](#can-port-data)
            - [Unversioned properties](#unversioned-properties)
                - [CAN Message Signal](#can-message-signal)
                - [Segment](#segment)
                - [Source Address](#source-address)
                - [Destination Address](#destination-address)
            - [Versioned properties](#versioned-properties)
        - [DirectWire Port Data](#directwire-port-data)
            - [Unversioned properties](#unversioned-properties)
            - [Versioned properties](#versioned-properties)
        - [Internal Port Data](#internal-port-data)
            - [Unversioned properties](#unversioned-properties)
            - [Versioned properties](#versioned-properties)
        - [Can Message](#can-message)
            - [Unversioned properties](#unversioned-properties)
            - [Versioned properties](#versioned-properties)
                - [Cycle Time](#cycle-time)
                - [Data Length](#data-length)
                - [Message Note](#message-note)
                - [Parameter Group Number (PGN)](#parameter-group-number-pgn)
                - [PG Diagnostic Type](#pg-diagnostic-type)
                - [PG Prio](#pg-prio)
                - [PG Repetition Type](#pg-repetition-type)
                - [TMax](#tmax)
                - [TMin](#tmin)
            - [Derived Properties](#derived-properties)
                - [Free Bits](#free-bits)
                - [Max Consecutive Free Bits](#max-consecutive-free-bits)
                - [Data Length in Bits](#data-length-in-bits)
        - [Can Signal](#can-signal)
            - [Unversioned properties](#unversioned-properties)
            - [Versioned properties](#versioned-properties)
                - [Bit Size](#bit-size)
                - [Byte Order](#byte-order)
                - [Formula Factor](#formula-factor)
                - [Formula Offset](#formula-offset)
                - [Initial Value](#initial-value)
                - [Max](#max)
                - [Min](#min)
                - [Signal Note](#signal-note)
                - [Signal Type](#signal-type)
                - [Value Type](#value-type)
                - [SPN](#spn)
                - [Value Table Name](#value-table-name)
        - [Value Description](#value-description)
            - [Unversioned properties](#unversioned-properties)
                - [CAN Signal](#can-signal)
            - [Versioned properties](#versioned-properties)
                - [Value](#value)
                - [Description](#description)
        - [Can Multiplex Group](#can-multiplex-group)
            - [Unversioned properties](#unversioned-properties)
                - [Signal](#signal)
            - [Versioned properties](#versioned-properties)
                - [Value](#value)
    - [Helper objects](#helper-objects)
        - [User Function Relation](#user-function-relation)
            - [Unversioned properties](#unversioned-properties)
                - [Allocation Element Port](#allocation-element-port)
                - [User Function](#user-function)
        - [Scenario Relation](#scenario-relation)
            - [Unversioned properties](#unversioned-properties)
                - [Scenario](#scenario)
                - [Test Case](#test-case)
        - [Can Message-Signal Pair](#can-message-signal-pair)
            - [Unversioned properties](#unversioned-properties)
                - [CAN Message](#can-message)
                - [CAN Signal](#can-signal)
                - [Multiplex Group](#multiplex-group)
            - [Versioned properties](#versioned-properties)
                - [Start Bit](#start-bit)
        - [Segment Relation](#segment-relation)
            - [Unversioned Properties](#unversioned-properties)
    - [Anchor/Version model](#anchor-version-model)
        - [Example](#example)


## Common properties

Unless otherwise mentioned, all resources have the following properties.

### Unversioned properties
Unversioned properties are set when creating a resource, and may not be changed once the resource has been committed.

#### ID
The numeric identifier, if any (e.g. the numeric part of AE123, UF17, etc.). Not all types have an ID.  
The following types have an ID:

- Allocation Element
- Function Category
- Scenario
- Test Case
- Use Case
- User Function

#### Versioned properties
Versioned properties may be changed using a CR, and are affected by the versioning system as described in the chapter below.

##### Name
The name of a resource. Does not include the identifier or the type.

##### IsActive
Describes whether the resource is active or not. (Needs further definition)  
An Active item will be shown as such in visualizations and will be part of CAN Specifications and other reports.

#### Derived Properties
Derived properties are not directly editable, but depends on other properties, often presenting them in a more human readable form.  
As they are derived from other properties, they are affected by the Versioning system.

##### DisplayName
The DisplayName is the full human-readable label for a resource, e.g. (Add example)  
Usually includes the identifier (if any), and may also include some information about linked objects, such as the component allocation of an AE, or the Allocation Elements linked by a  DirectWire.  
This property is not directly editable, but instead depends on other properties.

##### ShortName



## Functional
The functional structure is mirrored in OAS, with the exception of Test Cases, and is generally a tree strucure:

- Function Category
    - User Function
        - Use Case
            - Scenario

Test cases also belong to this category, but a test case can belong to several Scenarios.  
The connection(s) to the logical layer is from the User Functions to Allocation Element Ports. A receiving (Rx) Allocation Element Port can be tagged with a User Function.



### Function Category
A functional grouping of User Functions. 
#### Versioned Properties
##### English Definition
##### Swedish Definition
##### Swedish Name



### User Function
An object that defines a User Function. A User function can only belong to one Function Category. See inline for more information. Similar to definition in SEIF.
See also https://wikiinline.scania.com/wiki/SESAMM_model_concept

#### Unversioned properties
##### Function Category
#### Versioned properties
##### English Definition
##### Swedish Definition
##### Swedish Name
##### OAS FPC
The FPC condition for the User Function, extracted from OAS. Cannot be edited manually.
##### Contact Person Service
##### Responsible Person


### Use Case
An object that defines a Use Case. A Use Case can only belong to one Use Function. See inline for more information.
#### Unversioned properties
##### User Function
#### Versioned properties
##### English Definition
##### Swedish Definition
##### Swedish Name
##### OAS FPC
The FPC condition for the Use Case, extracted from OAS. Cannot be edited manually.


### Scenario
An object that defines a Scenario. A Scenario can only belong to one Use Case. See inline for more information.
#### Unversioned properties
##### Use Case
#### Versioned properties
##### English Definition
##### Swedish Definition
##### Swedish Name
##### OAS FPC
The FPC condition for the scenario, extracted from OAS. Cannot be edited manually.
##### Valid Condition FPC
Preliminary FPC condition for the Scenario. Manually written and used when adding the Scenario to OAS.
##### Valid Condition Text
Textual representation of the condition for the Scenario. Used when adding the Scenario to OAS.


### Test Case
An object that defines a Test case that relates to one or more Scenarios. Testcase is an item used at integration test. (Not really sure of how it is used??)
#### Unversioned properties
#### Versioned properties
##### Description
##### Environment
##### FPC
##### Status
##### Test Type


## Logical


### Allocation Element
Inherited from SesammTool1 with the exception that Allocation Elements realized on different components are considered unique even if they have the same Id. See also Functional Element.

See also: https://wikiinline.scania.com/wiki/SESAMM_model_concept

Example: AE104 General Physical Estimation (COO8)

#### Unversioned properties
##### Component Allocation
Each Allocation element is linked to a Component.

#### Versioned properties
##### Description
##### Documentation



### Allocation Element Port
An Allocation element port is a mostly hidden object in the UI, but it is possibly the most important object in the model.  
A Port is the connection through which an Allocation Element either sends or receives a signal, whether it is through CAN, DirectWire, Internal or eventually through Ethernet.

The AEP has a direction Receive(Rx)/Transmit(Tx) that defines the direction of dataflow as seen from the Allocation Element. The AEP also has a timeline that defines if and when (related to SOP/SSCR) the relation is active. The AEP also has a relation to value descriptions in a Can-signal. The relation defines values that are “Excluded” (i.e. values that are not sent or received by the specific AEP).



#### Unversioned properties
##### Port Data
Each Allocation Element Port is connected to one Port Data Resource. This can be of any Port Data type, but if the Port Data is not of a broadcastable type (i.e. CAN), then only one transmitting (Tx) and one receiving (Rx) port is allowed to link to each Port Data resource.

##### Allocation Element
Each Allocation Element Port belongs to a single Allocation Element.

#### Versioned properties

##### Direction
The direction of the AE port (Rx or Tx).  
Although this is technically a versioned property, it should never be changed.

There are Derived helper properties related to this property:

- IsTx
- IsRx

These are available to more quickly sort and filter ports.



### Port Data

Port Data describes the information sent between two Allocation Elements. 
This is an abstract base class for the different types of communication available, currently:

- Can
- Direct Wire
- Internal

#### Derived Properties
##### Segment Display Name
The display name of the CAN Segment the Port Data is sent on, or the Port Data type if the Port Data is not a CAN Port Data.



## Physical



### Component
Inherited from SesammTool1 with the exception that one component can only be related to one ComponentCode. A Component can be of different types, it can be a complex ECU with multiple can-busses and other types of inputs and outputs (PWM, digital, analogue, …). It can also be a discrete lamp or switch with only wires attached to it.
An Allocation Element is “realized” on a Component. A Gateway is also “realized” on a Component.


Example: COO8, EMD1, APS2, Brake Pedal Potentiometer

#### Unversioned properties
##### Component code
A link to the component code object which defines the component code for the component.

#### Versioned properties
##### Full Name
##### Documentation
##### Owner
##### Generation

#### Derived Properties
##### Allocation Elements
A list of all Allocation Elements allocated to this component.

##### Segments
A list of all CAN Segments connected to this component.



### Component Code
Read from excel-sheet (“Component library”) found on “EPVS inline-page”.
There are also some “fake” component codes existing in SesammTool2 that are migrated from SesammTool1. A Component code has to be unique on a specific vehicle which means that if exactly the same hardware is used in multiple places on a vehicle it will get different Component Codes depending on where it is used. Different hardware can also have the same Component Code if they realize the “same” functionality but never exist together on a specific vehicle (ex. all generations of Coordinator (COO6, COO7, COO8 and COO9) have the same Component Code (E30).

Example: E30 COO

#### Unversioned properties
#### Versioned properties
##### Code
##### Code Type
##### Description

### Can Segment
This is a Can Segment. It is used to model one Can-bus. It has a name and is implicitly connected to a component via Can Port Data and Allocation Element.
#### Unversioned properties
#### Versioned properties
##### Bandwidth
##### Protocol
##### IsPrimary
A boolean indicating whether the segment is a Primary segment or a Subsegment.



### Can Address
This is a Can Address. Address is an 8 bit J1939 address that can be used as Source  Address (SA) or Destination Address (DA). See further in [J1939] 21.
#### Versioned Properties
##### Address
The CAN Address in a hexadecimal format (stored as an integer).

##### Full Name



### Component Code

#### Unversioned properties
#### Versioned properties
##### Code
##### Code Type
##### Description



### Gateway
This is a CAN Gateway. An object that connects two Can Port Data objects that are the same except that they are related to different segments. The object has a From and To relation to the Can Port Data objects. In  reality only complete  Can messages are allowed to be gated, but in in the architecture model it is modelled as gateway of individual Can Signals so that one knows the actual signal that is the reason for the message to be gated.
The Gateway object also has a mandatory relation to a Component that will implement the gating of the message.

#### Unversioned properties
##### Component
##### Source Can Port Data
##### Target Can Port Data


## Communication

### Can Port Data
A realization of Port Data used to model CAN-communication between two Allocation Elements. The Can Port Data is defined by the Segment (Can-bus), the Source address, Destination address, and the CanSignal contained in a Can Message. Destination address might be null if Can message is of type PDU2. To model Gateway (i.e. transfer of Can-information from one Can Segment to another Can Segment via a Component) there are Gateway Objects that connects two CAN Port Data Objects that (as a business-rule) only are allowed to differ in the segment used.
#### Unversioned properties
##### CAN Message Signal

##### Segment
##### Source Address
##### Destination Address
Will be `null` for non-p2p messages.
#### Versioned properties



### DirectWire Port Data
A port data realization used to model a single wire connected between two Allocation Elements. The wire can be used for analogue, digital, PWM, or other signals. Note! It is the information transferred using the wire that is modelled. For a PWM signal with two wires; ground and the actual signal, only one Direct Wire Port Data is modelled. The Direct Wire Port Data is defined by its name and the two endpoint Allocation Elements. Direct Wire Port Data has a direction defined with the producer of the information defined as Transmitter (Tx) and the consumer of the information as the Receiver (Rx). E.g. If a an analogue temperature sensor is connected to an ECU the Sensor has the Tx-side and the ECU the Rx-side.
#### Unversioned properties
#### Versioned properties



### Internal Port Data
A port data realization used to denote internal data connected between two Allocation Elements realized on the same Component. It is normally a RTDB-variable or other internal variable that is used to transfer information between two software units in the same ECU.
The Internal Port Data is defined by its name and the two endpoint Allocation Elements. Internal Port Data has a direction defined with the producer of the information defined as Transmitter (Tx) and the consumer of the information as the Receiver (Rx).

#### Unversioned properties
#### Versioned properties



### Can Message
A Can message as defined in [J1939] (or other similar standard).
A Can message has a relation to a number of Can Signals via an object called “Can Message Signal”. A Can Message has a PGN and a Name that uniquely defines it.

#### Unversioned properties
#### Versioned properties
##### Cycle Time
##### Data Length
The length of the message in bytes. 
##### Message Note
##### Parameter Group Number (PGN)
##### PG Diagnostic Type
##### PG Prio
##### PG Repetition Type
##### TMax
##### TMin

#### Derived Properties
##### Free Bits
The number of free bits in the message.

##### Max Consecutive Free Bits
The maximum number of consecutive free bits in the message.

##### Data Length in Bits
The length of the message in bits. This will always be 8 times the Data Length.



### Can Signal
A Can signal as defined in [J1939] (or other similar standard).
A Can signal has a relation to a Can Message via an object called “Can Message Signal”. It is possible to reuse a Can Signal in more than one Can Message. There is no architectural relation between two Can Signals in different Can Messages. A Can Signal has a Name that must be unique in the context of one Can Message. A Can Signal that is used to control other multiplexed Can Signals has a relation from that Mux Group.

#### Unversioned properties
#### Versioned properties
##### Bit Size
The length of a signal in bits

##### Byte Order
The byte order of the signal. Either Intel or Motorola.

##### Formula Factor
##### Formula Offset
##### Initial Value
##### Max
##### Min
##### Signal Note
##### Signal Type
##### Value Type
##### SPN
##### Value Table Name



### Value Description
#### Unversioned properties
##### CAN Signal
#### Versioned properties
##### Value 
##### Description




### Can Multiplex Group
An object that relates to a Can Signal that is used as multiplexor. The Can Message Signals that are controlled by the Mux Group has a relation to that Mux Group. See further in documentation for CanDB++ (A Vector tool).

#### Unversioned properties
##### Signal
The multiplexor signal.

#### Versioned properties
##### Value


## Helper objects
Smaller objects, mostly to handle many-to-many relations between resources. These will mostly be edited and seen indirectly through the UI.

### User Function Relation
A helper object to handle the relation between User Functions and Allocation Element Ports, also known as the UF Tagging.

These relations will only point to receiving (Rx) Allocation Element Ports.

#### Unversioned properties
##### Allocation Element Port
##### User Function

### Scenario Relation
A helper object to handle the relation between Scenarios and Test Cases

#### Unversioned properties
##### Scenario
##### Test Case


### Can Message-Signal Pair

A CAN Message-Signal Pair is a helper object to allow a signal to be reused in several messages. A user will never have to deal directly with these objects.

They contain information about where in the particular message the signal goes, and also which multiplex group the signal belongs to in the particlar message, if any.

A Can Message Signal that is controlled by a Mux Group has a relation to a Mux Group.

#### Unversioned properties
##### CAN Message
##### CAN Signal
##### Multiplex Group
#### Versioned properties
##### Start Bit
The start bit of the signal in the message.



### Segment Relation
The relation between a component and a CAN segment.

The Segment Relations define what gateways can be created and which CAN segments Allocation Elements can transmit and receive CAN signals and messages on.

The Segment Relations define the CAN topology.

#### Unversioned Properties





## Anchor/Version model

A Resource is defined by an Anchor and a set of versions.  
Each version is linked to a Change Request, and thus, in most cases, to a SOP.

To find the values of a Resource at a particular point in time, with a given configuration (e.g. at a particular SOP or Test Week, with CRs in a particular state), we first find the set of versions linked to CRs that match the given criteria. We then sort those versions, first according to the SOP of their linked CR, then by the date they were committed. 
> If the version in question is still in a Workspace, the creation date of that version is used instead. (Investigate)  

The value for each property is the last *non-null* value for that property in this sorted list. This means that a null value for any property in a version means "use the previous value", which in turn means that changes to such values at an earlier SOP will not be "blocked" by the version at the later SOP date (because of the sorting earlier).

### Example

A simplified UF has the following properties (The Versioned column indicates whether the property follows the versioning system):

| Property    | Versioned |
| ----------- | --------- |
| ID          | no        |
| Name        | yes       |
| Description | yes       |
| IsActive    | yes       |

When creating a new Resource, we always create a baseline version and link it to our baseline CR: CR0. Since this new UF has not been active since the beginning of time, we will set the IsActive property to false, and the baseline version will look something like this:

| Name  | Description | IsActive | CR  | SOP  | Commit Time      |
| ----- | ----------- | -------- | --- | ---- | ---------------- |
| My UF | Desc1       | false    | CR0 | none | 2018-04-20 15:23 |

>Note that the ID is not included here, as it is not a versioned attribute. Technically the ID attribute resides on the Anchor.

We then create a version that activates this UF, using a CR with a SOP, so we end up with the following two versions:

| Name    | Description | IsActive | CR  | SOP     | Commit Time      |
| ------- | ----------- | -------- | --- | ------- | ---------------- |
| My UF   | Desc1       | false    | CR0 | none    | 2018-04-20 15:23 |
| \<null> | \<null>     | true     | CR1 | SOP1812 | 2018-04-20 15:30 |



The next week we realize that maybe "My UF" and "Desc1" aren't the best names for our UF, and decide to change them. In this example we've already created and synced a CR to use with this (CR0 is only used to create the baseline version). We end up with the following:

| Name              | Description                                                                | IsActive | CR  | SOP     | Commit Time      |
| ----------------- | -------------------------------------------------------------------------- | -------- | --- | ------- | ---------------- |
| My UF             | Desc1                                                                      | false    | CR0 | none    | 2018-04-20 15:23 |
| Levitation module | When enabled, allows the truck to hover in the air to avoid heavy traffic. | \<null>  | CR2 | none    | 2018-04-23 12:23 |
| \<null>           | \<null>                                                                    | true     | CR1 | SOP1812 | 2018-04-20 15:30 |

Note that this list is now sorted according to above, and the new CR without a SOP is placed before the CR with the activation, but after the baseline CR, because of the later date.  
Because we set the values for Name and Description to \<null> with CR1, the newly added values will be used, regardless of which SOP we're looking at.

If needed, it is possible to set a new description or name at a particular SOP, simply by using a CR with that SOP date:

| Name              | Description                                                                                             | IsActive | CR  | SOP     | Commit Time      |
| ----------------- | ------------------------------------------------------------------------------------------------------- | -------- | --- | ------- | ---------------- |
| My UF             | Desc1                                                                                                   | false    | CR0 | none    | 2018-04-20 15:23 |
| Levitation module | When enabled, allows the truck to hover in the air to avoid heavy traffic.                              | \<null>  | CR2 | none    | 2018-04-23 12:23 |
| \<null>           | \<null>                                                                                                 | true     | CR1 | SOP1812 | 2018-04-20 15:30 |
| \<null>           | When enabled, allows the truck to hover in the air to avoid heavy traffic or deliver goods to airdocks. | \<null>  | CR3 | SOP2405 | 2023-01-19 11:40 |

### Other terminology

#### Allocation Element Interface (AE-interface)
A collection of Allocation Element Ports connected to one Allocation Element. Each Allocation Element Port is connected to exactly one Allocation Element (i.e. they can’t be reused between Allocation Elements). 
Each Allocation Element Port is related to an abstract object called PortData that is used to connect Allocation Element Ports together in different configurations (Point to Point, broadcast, input(Rx), output(Tx), …). 
Port Data can be realized in different ways (ex. Can Port Data, Direct Wire Port Data, Internal Port Data, …)

Example:

| Direction | Message | Signal | Segment | Source |
|---|---|---|---|---|
|Tx|	ICLInformationProprietary |	AuxiliaryAmbientAirTemperature	| Yellow |	ICL (0x17) - Instrument Cluster|
|Tx|	AmbientConditions|	AmbientAirTemperature|	Yellow|	ICL (0x17) - Instrument Cluster|
|Rx|	| 	AmbientAirTemperature|	DirectWire|	 
|Rx|	| 	AmbientAirTemperature|	DirectWire	 |
|Tx|	| 	BlackIceWarning |DirectWire	 |

#### Functional Element (FE)
Not implemented yet in SesammTool2. From [SEIF] (will for future modelling replace AE, with modified definition (TBD))
