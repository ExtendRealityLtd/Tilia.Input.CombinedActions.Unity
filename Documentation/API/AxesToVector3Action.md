# Class AxesToVector3Action

Converts a lateral, vertical and longitudinal float representation into a Vector3 action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [DeadzoneCalculation]
  * [InputType]
  * [LateralAxis]
  * [LateralDeadzone]
  * [LongitudinalAxis]
  * [LongitudinalDeadzone]
  * [Multiplier]
  * [TimeMultiplier]
  * [VerticalAxis]
  * [VerticalDeadzone]
* [Methods]
  * [ClearLateralAxis()]
  * [ClearLongitudinalAxis()]
  * [ClearVerticalAxis()]
  * [OnAfterDeadzoneCalculationChange()]
  * [OnAfterInputTypeChange()]
  * [OnAfterLateralAxisChange()]
  * [OnAfterLateralDeadzoneChange()]
  * [OnAfterLongitudinalAxisChange()]
  * [OnAfterLongitudinalDeadzoneChange()]
  * [OnAfterMultiplierChange()]
  * [OnAfterTimeMultiplierChange()]
  * [OnAfterVerticalAxisChange()]
  * [OnAfterVerticalDeadzoneChange()]
  * [OnEnable()]
  * [SetDeadzoneCalculation(Int32)]
  * [SetInputType(Int32)]
  * [SetLateralDeadzoneMaximum(Single)]
  * [SetLateralDeadzoneMinimum(Single)]
  * [SetLongitudinalDeadzoneMaximum(Single)]
  * [SetLongitudinalDeadzoneMinimum(Single)]
  * [SetMultiplierX(Single)]
  * [SetMultiplierY(Single)]
  * [SetMultiplierZ(Single)]
  * [SetTimeMultiplier(Int32)]
  * [SetVerticalDeadzoneMaximum(Single)]
  * [SetVerticalDeadzoneMinimum(Single)]

## Details

##### Inheritance

* System.Object
* AxesToVector3Action

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class AxesToVector3Action : Vector3Action
```

### Properties

#### Configuration

The linked Internal Setup.

##### Declaration

```
public AxesToVector3ActionConfigurator Configuration { get; protected set; }
```

#### DeadzoneCalculation

The way in which the deadzone is calculated by the input axes.

##### Declaration

```
public AxesToVector3Action.DeadzoneType DeadzoneCalculation { get; set; }
```

#### InputType

Determines how to handle the axis input data to control the Vector3 output.

##### Declaration

```
public AxesToVector3Action.InputHandler InputType { get; set; }
```

#### LateralAxis

The FloatAction representing the Lateral (X Axis)\[left/right\].

##### Declaration

```
public FloatAction LateralAxis { get; set; }
```

#### LateralDeadzone

The bounds in which the Lateral Axis is considered inactive.

##### Declaration

```
public FloatRange LateralDeadzone { get; set; }
```

#### LongitudinalAxis

The FloatAction representing the Longitudinal (Z Axis)\[forward/backward\].

##### Declaration

```
public FloatAction LongitudinalAxis { get; set; }
```

#### LongitudinalDeadzone

The bounds in which the Longitudinal Axis is considered inactive.

##### Declaration

```
public FloatRange LongitudinalDeadzone { get; set; }
```

#### Multiplier

Multiply the output values.

##### Declaration

```
public Vector3 Multiplier { get; set; }
```

#### TimeMultiplier

Multiply the output values by this Time component.

##### Declaration

```
public TimeComponentExtractor.TimeComponent TimeMultiplier { get; set; }
```

#### VerticalAxis

The FloatAction representing the Vertical (Y Axis)\[up/down\].

##### Declaration

```
public FloatAction VerticalAxis { get; set; }
```

#### VerticalDeadzone

The bounds in which the Vertical Axis is considered inactive.

##### Declaration

```
public FloatRange VerticalDeadzone { get; set; }
```

### Methods

#### ClearLateralAxis()

Clears [LateralAxis].

##### Declaration

```
public virtual void ClearLateralAxis()
```

#### ClearLongitudinalAxis()

Clears [LongitudinalAxis].

##### Declaration

```
public virtual void ClearLongitudinalAxis()
```

#### ClearVerticalAxis()

Clears [VerticalAxis].

##### Declaration

```
public virtual void ClearVerticalAxis()
```

#### OnAfterDeadzoneCalculationChange()

Called after [DeadzoneCalculation] has been changed.

##### Declaration

```
protected virtual void OnAfterDeadzoneCalculationChange()
```

#### OnAfterInputTypeChange()

Called after [InputType] has been changed.

##### Declaration

```
protected virtual void OnAfterInputTypeChange()
```

#### OnAfterLateralAxisChange()

Called after [LateralAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterLateralAxisChange()
```

#### OnAfterLateralDeadzoneChange()

Called after [LateralDeadzone] has been changed.

##### Declaration

```
protected virtual void OnAfterLateralDeadzoneChange()
```

#### OnAfterLongitudinalAxisChange()

Called after [LongitudinalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterLongitudinalAxisChange()
```

#### OnAfterLongitudinalDeadzoneChange()

Called after [LongitudinalDeadzone] has been changed.

##### Declaration

```
protected virtual void OnAfterLongitudinalDeadzoneChange()
```

#### OnAfterMultiplierChange()

Called after [Multiplier] has been changed.

##### Declaration

```
protected virtual void OnAfterMultiplierChange()
```

#### OnAfterTimeMultiplierChange()

Called after [TimeMultiplier] has been changed.

##### Declaration

```
protected virtual void OnAfterTimeMultiplierChange()
```

#### OnAfterVerticalAxisChange()

Called after [VerticalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterVerticalAxisChange()
```

#### OnAfterVerticalDeadzoneChange()

Called after [VerticalDeadzone] has been changed.

##### Declaration

```
protected virtual void OnAfterVerticalDeadzoneChange()
```

#### OnEnable()

##### Declaration

```
protected override void OnEnable()
```

#### SetDeadzoneCalculation(Int32)

Sets [DeadzoneCalculation].

##### Declaration

```
public virtual void SetDeadzoneCalculation(int deadzoneTypeIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | deadzoneTypeIndex | The index of the [AxesToVector3Action.DeadzoneType]. |

#### SetInputType(Int32)

Sets [InputType].

##### Declaration

```
public virtual void SetInputType(int inputTypeIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | inputTypeIndex | The index of the [AxesToVector3Action.InputHandler]. |

#### SetLateralDeadzoneMaximum(Single)

Sets the [LateralDeadzone] maximum value.

##### Declaration

```
public virtual void SetLateralDeadzoneMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new maximum value. |

#### SetLateralDeadzoneMinimum(Single)

Sets the [LateralDeadzone] minimum value.

##### Declaration

```
public virtual void SetLateralDeadzoneMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new minimum value. |

#### SetLongitudinalDeadzoneMaximum(Single)

Sets the [LongitudinalDeadzone] maximum value.

##### Declaration

```
public virtual void SetLongitudinalDeadzoneMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new maximum value. |

#### SetLongitudinalDeadzoneMinimum(Single)

Sets the [LongitudinalDeadzone] minimum value.

##### Declaration

```
public virtual void SetLongitudinalDeadzoneMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new minimum value. |

#### SetMultiplierX(Single)

Sets the [Multiplier] x value.

##### Declaration

```
public virtual void SetMultiplierX(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set to. |

#### SetMultiplierY(Single)

Sets the [Multiplier] y value.

##### Declaration

```
public virtual void SetMultiplierY(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set to. |

#### SetMultiplierZ(Single)

Sets the [Multiplier] z value.

##### Declaration

```
public virtual void SetMultiplierZ(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set to. |

#### SetTimeMultiplier(Int32)

Sets [TimeMultiplier].

##### Declaration

```
public virtual void SetTimeMultiplier(int timeMultiplierIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | timeMultiplierIndex | The index of the TimeComponentExtractor.TimeComponent. |

#### SetVerticalDeadzoneMaximum(Single)

Sets the [VerticalDeadzone] maximum value.

##### Declaration

```
public virtual void SetVerticalDeadzoneMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new maximum value. |

#### SetVerticalDeadzoneMinimum(Single)

Sets the [VerticalDeadzone] minimum value.

##### Declaration

```
public virtual void SetVerticalDeadzoneMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new minimum value. |

[Tilia.Input.CombinedActions]: README.md
[AxesToVector3ActionConfigurator]: AxesToVector3ActionConfigurator.md
[LateralAxis]: AxesToVector3Action.md#LateralAxis
[LongitudinalAxis]: AxesToVector3Action.md#LongitudinalAxis
[VerticalAxis]: AxesToVector3Action.md#VerticalAxis
[DeadzoneCalculation]: AxesToVector3Action.md#DeadzoneCalculation
[InputType]: AxesToVector3Action.md#InputType
[LateralAxis]: AxesToVector3Action.md#LateralAxis
[LateralDeadzone]: AxesToVector3Action.md#LateralDeadzone
[LongitudinalAxis]: AxesToVector3Action.md#LongitudinalAxis
[LongitudinalDeadzone]: AxesToVector3Action.md#LongitudinalDeadzone
[Multiplier]: AxesToVector3Action.md#Multiplier
[TimeMultiplier]: AxesToVector3Action.md#TimeMultiplier
[VerticalAxis]: AxesToVector3Action.md#VerticalAxis
[VerticalDeadzone]: AxesToVector3Action.md#VerticalDeadzone
[DeadzoneCalculation]: AxesToVector3Action.md#DeadzoneCalculation
[AxesToVector3Action.DeadzoneType]: AxesToVector3Action.DeadzoneType.md
[InputType]: AxesToVector3Action.md#InputType
[AxesToVector3Action.InputHandler]: AxesToVector3Action.InputHandler.md
[LateralDeadzone]: AxesToVector3Action.md#LateralDeadzone
[LateralDeadzone]: AxesToVector3Action.md#LateralDeadzone
[LongitudinalDeadzone]: AxesToVector3Action.md#LongitudinalDeadzone
[LongitudinalDeadzone]: AxesToVector3Action.md#LongitudinalDeadzone
[Multiplier]: AxesToVector3Action.md#Multiplier
[Multiplier]: AxesToVector3Action.md#Multiplier
[Multiplier]: AxesToVector3Action.md#Multiplier
[TimeMultiplier]: AxesToVector3Action.md#TimeMultiplier
[VerticalDeadzone]: AxesToVector3Action.md#VerticalDeadzone
[VerticalDeadzone]: AxesToVector3Action.md#VerticalDeadzone
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[DeadzoneCalculation]: #DeadzoneCalculation
[InputType]: #InputType
[LateralAxis]: #LateralAxis
[LateralDeadzone]: #LateralDeadzone
[LongitudinalAxis]: #LongitudinalAxis
[LongitudinalDeadzone]: #LongitudinalDeadzone
[Multiplier]: #Multiplier
[TimeMultiplier]: #TimeMultiplier
[VerticalAxis]: #VerticalAxis
[VerticalDeadzone]: #VerticalDeadzone
[Methods]: #Methods
[ClearLateralAxis()]: #ClearLateralAxis
[ClearLongitudinalAxis()]: #ClearLongitudinalAxis
[ClearVerticalAxis()]: #ClearVerticalAxis
[OnAfterDeadzoneCalculationChange()]: #OnAfterDeadzoneCalculationChange
[OnAfterInputTypeChange()]: #OnAfterInputTypeChange
[OnAfterLateralAxisChange()]: #OnAfterLateralAxisChange
[OnAfterLateralDeadzoneChange()]: #OnAfterLateralDeadzoneChange
[OnAfterLongitudinalAxisChange()]: #OnAfterLongitudinalAxisChange
[OnAfterLongitudinalDeadzoneChange()]: #OnAfterLongitudinalDeadzoneChange
[OnAfterMultiplierChange()]: #OnAfterMultiplierChange
[OnAfterTimeMultiplierChange()]: #OnAfterTimeMultiplierChange
[OnAfterVerticalAxisChange()]: #OnAfterVerticalAxisChange
[OnAfterVerticalDeadzoneChange()]: #OnAfterVerticalDeadzoneChange
[OnEnable()]: #OnEnable
[SetDeadzoneCalculation(Int32)]: #SetDeadzoneCalculationInt32
[SetInputType(Int32)]: #SetInputTypeInt32
[SetLateralDeadzoneMaximum(Single)]: #SetLateralDeadzoneMaximumSingle
[SetLateralDeadzoneMinimum(Single)]: #SetLateralDeadzoneMinimumSingle
[SetLongitudinalDeadzoneMaximum(Single)]: #SetLongitudinalDeadzoneMaximumSingle
[SetLongitudinalDeadzoneMinimum(Single)]: #SetLongitudinalDeadzoneMinimumSingle
[SetMultiplierX(Single)]: #SetMultiplierXSingle
[SetMultiplierY(Single)]: #SetMultiplierYSingle
[SetMultiplierZ(Single)]: #SetMultiplierZSingle
[SetTimeMultiplier(Int32)]: #SetTimeMultiplierInt32
[SetVerticalDeadzoneMaximum(Single)]: #SetVerticalDeadzoneMaximumSingle
[SetVerticalDeadzoneMinimum(Single)]: #SetVerticalDeadzoneMinimumSingle
