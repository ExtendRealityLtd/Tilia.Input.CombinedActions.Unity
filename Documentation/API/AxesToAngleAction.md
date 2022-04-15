# Class AxesToAngleAction

Converts a the given axis data into an output angle.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [DirectionOffset]
  * [HorizontalAxis]
  * [HorizontalDeadzone]
  * [VerticalAxis]
  * [VerticalDeadzone]
* [Methods]
  * [ClearDirectionOffset()]
  * [ClearHorizontalAxis()]
  * [ClearVerticalAxis()]
  * [OnAfterDirectionOffsetChange()]
  * [OnAfterHorizontalAxisChange()]
  * [OnAfterHorizontalDeadzoneChange()]
  * [OnAfterVerticalAxisChange()]
  * [OnAfterVerticalDeadzoneChange()]
  * [OnEnable()]
  * [SetHorizontalDeadzoneMaximum(Single)]
  * [SetHorizontalDeadzoneMinimum(Single)]
  * [SetVerticalDeadzoneMaximum(Single)]
  * [SetVerticalDeadzoneMinimum(Single)]

## Details

##### Inheritance

* System.Object
* AxesToAngleAction

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class AxesToAngleAction : FloatAction
```

### Properties

#### Configuration

The linked Internal Setup.

##### Declaration

```
public AxesToAngleActionConfigurator Configuration { get; protected set; }
```

#### DirectionOffset

An optional GameObject to be used as the direction offset for the output axis angle.

##### Declaration

```
public GameObject DirectionOffset { get; set; }
```

#### HorizontalAxis

The FloatAction that represents the Horizontal Axis.

##### Declaration

```
public FloatAction HorizontalAxis { get; set; }
```

#### HorizontalDeadzone

The bounds in which the Horizontal Axis is considered inactive.

##### Declaration

```
public FloatRange HorizontalDeadzone { get; set; }
```

#### VerticalAxis

The FloatAction that represents the Vertical Axis.

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

#### ClearDirectionOffset()

Clears [DirectionOffset].

##### Declaration

```
public virtual void ClearDirectionOffset()
```

#### ClearHorizontalAxis()

Clears [HorizontalAxis].

##### Declaration

```
public virtual void ClearHorizontalAxis()
```

#### ClearVerticalAxis()

Clears [VerticalAxis].

##### Declaration

```
public virtual void ClearVerticalAxis()
```

#### OnAfterDirectionOffsetChange()

Called after [DirectionOffset] has been changed.

##### Declaration

```
protected virtual void OnAfterDirectionOffsetChange()
```

#### OnAfterHorizontalAxisChange()

Called after [HorizontalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterHorizontalAxisChange()
```

#### OnAfterHorizontalDeadzoneChange()

Called after [HorizontalDeadzone] has been changed.

##### Declaration

```
protected virtual void OnAfterHorizontalDeadzoneChange()
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

#### SetHorizontalDeadzoneMaximum(Single)

Sets the [HorizontalDeadzone] maximum value.

##### Declaration

```
public virtual void SetHorizontalDeadzoneMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new maximum value. |

#### SetHorizontalDeadzoneMinimum(Single)

Sets the [HorizontalDeadzone] minimum value.

##### Declaration

```
public virtual void SetHorizontalDeadzoneMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new minimum value. |

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
[AxesToAngleActionConfigurator]: AxesToAngleActionConfigurator.md
[DirectionOffset]: AxesToAngleAction.md#DirectionOffset
[HorizontalAxis]: AxesToAngleAction.md#HorizontalAxis
[VerticalAxis]: AxesToAngleAction.md#VerticalAxis
[DirectionOffset]: AxesToAngleAction.md#DirectionOffset
[HorizontalAxis]: AxesToAngleAction.md#HorizontalAxis
[HorizontalDeadzone]: AxesToAngleAction.md#HorizontalDeadzone
[VerticalAxis]: AxesToAngleAction.md#VerticalAxis
[VerticalDeadzone]: AxesToAngleAction.md#VerticalDeadzone
[HorizontalDeadzone]: AxesToAngleAction.md#HorizontalDeadzone
[HorizontalDeadzone]: AxesToAngleAction.md#HorizontalDeadzone
[VerticalDeadzone]: AxesToAngleAction.md#VerticalDeadzone
[VerticalDeadzone]: AxesToAngleAction.md#VerticalDeadzone
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[DirectionOffset]: #DirectionOffset
[HorizontalAxis]: #HorizontalAxis
[HorizontalDeadzone]: #HorizontalDeadzone
[VerticalAxis]: #VerticalAxis
[VerticalDeadzone]: #VerticalDeadzone
[Methods]: #Methods
[ClearDirectionOffset()]: #ClearDirectionOffset
[ClearHorizontalAxis()]: #ClearHorizontalAxis
[ClearVerticalAxis()]: #ClearVerticalAxis
[OnAfterDirectionOffsetChange()]: #OnAfterDirectionOffsetChange
[OnAfterHorizontalAxisChange()]: #OnAfterHorizontalAxisChange
[OnAfterHorizontalDeadzoneChange()]: #OnAfterHorizontalDeadzoneChange
[OnAfterVerticalAxisChange()]: #OnAfterVerticalAxisChange
[OnAfterVerticalDeadzoneChange()]: #OnAfterVerticalDeadzoneChange
[OnEnable()]: #OnEnable
[SetHorizontalDeadzoneMaximum(Single)]: #SetHorizontalDeadzoneMaximumSingle
[SetHorizontalDeadzoneMinimum(Single)]: #SetHorizontalDeadzoneMinimumSingle
[SetVerticalDeadzoneMaximum(Single)]: #SetVerticalDeadzoneMaximumSingle
[SetVerticalDeadzoneMinimum(Single)]: #SetVerticalDeadzoneMinimumSingle
