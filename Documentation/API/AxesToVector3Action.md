# Class AxesToVector3Action

Converts a lateral, vertical and longitudinal float representation into a Vector3 action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
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
  * [SetMultiplierX(Single)]
  * [SetMultiplierY(Single)]
  * [SetMultiplierZ(Single)]

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

[Tilia.Input.CombinedActions]: README.md
[AxesToVector3ActionConfigurator]: AxesToVector3ActionConfigurator.md
[AxesToVector3Action.InputHandler]: AxesToVector3Action.InputHandler.md
[InputType]: AxesToVector3Action.md#InputType
[LateralAxis]: AxesToVector3Action.md#LateralAxis
[LateralDeadzone]: AxesToVector3Action.md#LateralDeadzone
[LongitudinalAxis]: AxesToVector3Action.md#LongitudinalAxis
[LongitudinalDeadzone]: AxesToVector3Action.md#LongitudinalDeadzone
[Multiplier]: AxesToVector3Action.md#Multiplier
[TimeMultiplier]: AxesToVector3Action.md#TimeMultiplier
[VerticalAxis]: AxesToVector3Action.md#VerticalAxis
[VerticalDeadzone]: AxesToVector3Action.md#VerticalDeadzone
[Multiplier]: AxesToVector3Action.md#Multiplier
[Multiplier]: AxesToVector3Action.md#Multiplier
[Multiplier]: AxesToVector3Action.md#Multiplier
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
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
[SetMultiplierX(Single)]: #SetMultiplierXSingle
[SetMultiplierY(Single)]: #SetMultiplierYSingle
[SetMultiplierZ(Single)]: #SetMultiplierZSingle
