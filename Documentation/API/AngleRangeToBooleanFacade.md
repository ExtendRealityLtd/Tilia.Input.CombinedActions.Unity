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
  * [OnAfterAngleRangeChange()]
  * [OnAfterHorizontalAxisChange()]
  * [OnAfterHorizontalDeadzoneChange()]
  * [OnAfterUnitTypeChange()]
  * [OnAfterVerticalAxisChange()]
  * [OnAfterVerticalDeadzoneChange()]

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

[Tilia.Input.CombinedActions]: README.md
[AngleRangeToBooleanConfigurator]: AngleRangeToBooleanConfigurator.md
[AngleRange]: AngleRangeToBooleanFacade.md#AngleRange
[HorizontalAxis]: AngleRangeToBooleanFacade.md#HorizontalAxis
[HorizontalDeadzone]: AngleRangeToBooleanFacade.md#HorizontalDeadzone
[UnitType]: AngleRangeToBooleanFacade.md#UnitType
[VerticalAxis]: AngleRangeToBooleanFacade.md#VerticalAxis
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
[OnAfterAngleRangeChange()]: #OnAfterAngleRangeChange
[OnAfterHorizontalAxisChange()]: #OnAfterHorizontalAxisChange
[OnAfterHorizontalDeadzoneChange()]: #OnAfterHorizontalDeadzoneChange
[OnAfterUnitTypeChange()]: #OnAfterUnitTypeChange
[OnAfterVerticalAxisChange()]: #OnAfterVerticalAxisChange
[OnAfterVerticalDeadzoneChange()]: #OnAfterVerticalDeadzoneChange
