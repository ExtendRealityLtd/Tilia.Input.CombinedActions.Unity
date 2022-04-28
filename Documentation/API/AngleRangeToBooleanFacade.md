# Class AngleRangeToBooleanFacade

The public interface into the AngleRangeToBoolean Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AngleRange]
  * [Configuration]
  * [HorizontalAxis]
  * [HorizontalDeadzone]
  * [UnitType]
  * [VerticalAxis]
  * [VerticalDeadzone]
* [Methods]
  * [ClearHorizontalAxis()]
  * [ClearVerticalAxis()]
  * [OnAfterAngleRangeChange()]
  * [OnAfterHorizontalAxisChange()]
  * [OnAfterHorizontalDeadzoneChange()]
  * [OnAfterUnitTypeChange()]
  * [OnAfterVerticalAxisChange()]
  * [OnAfterVerticalDeadzoneChange()]
  * [SetAngleRangeMaximum(Single)]
  * [SetAngleRangeMinimum(Single)]
  * [SetHorizontalDeadzoneMaximum(Single)]
  * [SetHorizontalDeadzoneMinimum(Single)]
  * [SetUnitType(Int32)]
  * [SetVerticalDeadzoneMaximum(Single)]
  * [SetVerticalDeadzoneMinimum(Single)]

## Details

##### Inheritance

* System.Object
* AngleRangeToBooleanFacade

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class AngleRangeToBooleanFacade : MonoBehaviour
```

### Properties

#### AngleRange

The range of the angle to consider true.

##### Declaration

```
public FloatRange AngleRange { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public AngleRangeToBooleanConfigurator Configuration { get; protected set; }
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

#### UnitType

The units in which to determine the angle range in.

##### Declaration

```
public Vector2ToAngle.AngleUnit UnitType { get; set; }
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

#### OnAfterAngleRangeChange()

Called after [AngleRange] has been changed.

##### Declaration

```
protected virtual void OnAfterAngleRangeChange()
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

#### OnAfterUnitTypeChange()

Called after [UnitType] has been changed.

##### Declaration

```
protected virtual void OnAfterUnitTypeChange()
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

#### SetAngleRangeMaximum(Single)

Sets the [AngleRange] maximum value.

##### Declaration

```
public virtual void SetAngleRangeMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new maximum value. |

#### SetAngleRangeMinimum(Single)

Sets the [AngleRange] minimum value.

##### Declaration

```
public virtual void SetAngleRangeMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new minimum value. |

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

#### SetUnitType(Int32)

Sets [UnitType].

##### Declaration

```
public virtual void SetUnitType(int unitTypeIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | unitTypeIndex | The index of the Vector2ToAngle.AngleUnit. |

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
[AngleRangeToBooleanConfigurator]: AngleRangeToBooleanConfigurator.md
[HorizontalAxis]: AngleRangeToBooleanFacade.md#HorizontalAxis
[VerticalAxis]: AngleRangeToBooleanFacade.md#VerticalAxis
[AngleRange]: AngleRangeToBooleanFacade.md#AngleRange
[HorizontalAxis]: AngleRangeToBooleanFacade.md#HorizontalAxis
[HorizontalDeadzone]: AngleRangeToBooleanFacade.md#HorizontalDeadzone
[UnitType]: AngleRangeToBooleanFacade.md#UnitType
[VerticalAxis]: AngleRangeToBooleanFacade.md#VerticalAxis
[VerticalDeadzone]: AngleRangeToBooleanFacade.md#VerticalDeadzone
[AngleRange]: AngleRangeToBooleanFacade.md#AngleRange
[AngleRange]: AngleRangeToBooleanFacade.md#AngleRange
[HorizontalDeadzone]: AngleRangeToBooleanFacade.md#HorizontalDeadzone
[HorizontalDeadzone]: AngleRangeToBooleanFacade.md#HorizontalDeadzone
[UnitType]: AngleRangeToBooleanFacade.md#UnitType
[VerticalDeadzone]: AngleRangeToBooleanFacade.md#VerticalDeadzone
[VerticalDeadzone]: AngleRangeToBooleanFacade.md#VerticalDeadzone
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AngleRange]: #AngleRange
[Configuration]: #Configuration
[HorizontalAxis]: #HorizontalAxis
[HorizontalDeadzone]: #HorizontalDeadzone
[UnitType]: #UnitType
[VerticalAxis]: #VerticalAxis
[VerticalDeadzone]: #VerticalDeadzone
[Methods]: #Methods
[ClearHorizontalAxis()]: #ClearHorizontalAxis
[ClearVerticalAxis()]: #ClearVerticalAxis
[OnAfterAngleRangeChange()]: #OnAfterAngleRangeChange
[OnAfterHorizontalAxisChange()]: #OnAfterHorizontalAxisChange
[OnAfterHorizontalDeadzoneChange()]: #OnAfterHorizontalDeadzoneChange
[OnAfterUnitTypeChange()]: #OnAfterUnitTypeChange
[OnAfterVerticalAxisChange()]: #OnAfterVerticalAxisChange
[OnAfterVerticalDeadzoneChange()]: #OnAfterVerticalDeadzoneChange
[SetAngleRangeMaximum(Single)]: #SetAngleRangeMaximumSingle
[SetAngleRangeMinimum(Single)]: #SetAngleRangeMinimumSingle
[SetHorizontalDeadzoneMaximum(Single)]: #SetHorizontalDeadzoneMaximumSingle
[SetHorizontalDeadzoneMinimum(Single)]: #SetHorizontalDeadzoneMinimumSingle
[SetUnitType(Int32)]: #SetUnitTypeInt32
[SetVerticalDeadzoneMaximum(Single)]: #SetVerticalDeadzoneMaximumSingle
[SetVerticalDeadzoneMinimum(Single)]: #SetVerticalDeadzoneMinimumSingle
