# Class AxesToAngleActionConfigurator

Sets up the AxesToAngleAction prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AngleConverter]
  * [DirectionExtractor]
  * [HorizontalAxis]
  * [HorizontalDeadZone]
  * [VerticalAxis]
  * [VerticalDeadZone]
* [Methods]
  * [SetDeadzone(FloatRange, FloatToBoolean)]
  * [SetDirectionExtractorSource(GameObject)]
  * [SetHorizontalDeadzone(FloatRange)]
  * [SetHorizontalInputSource(FloatAction)]
  * [SetInputSource(FloatAction, FloatAction)]
  * [SetVerticalDeadzone(FloatRange)]
  * [SetVerticalInputSource(FloatAction)]

## Details

##### Inheritance

* System.Object
* AxesToAngleActionConfigurator

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class AxesToAngleActionConfigurator : MonoBehaviour
```

### Properties

#### AngleConverter

The vector2 to angle converter.

##### Declaration

```
public Vector2ToAngle AngleConverter { get; set; }
```

#### DirectionExtractor

The direction extractor for the direction offset.

##### Declaration

```
public TransformDirectionExtractor DirectionExtractor { get; set; }
```

#### HorizontalAxis

The FloatAction that represents the Horizontal Axis.

##### Declaration

```
public FloatAction HorizontalAxis { get; set; }
```

#### HorizontalDeadZone

The horizontal deadzone controller.

##### Declaration

```
public FloatToBoolean HorizontalDeadZone { get; set; }
```

#### VerticalAxis

The FloatAction that represents the Vertical Axis.

##### Declaration

```
public FloatAction VerticalAxis { get; set; }
```

#### VerticalDeadZone

The vertical deadzone controller.

##### Declaration

```
public FloatToBoolean VerticalDeadZone { get; set; }
```

### Methods

#### SetDeadzone(FloatRange, FloatToBoolean)

Sets the target deadzone based on the given source.

##### Declaration

```
protected virtual void SetDeadzone(FloatRange source, FloatToBoolean target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | source | The new deadzone range. |
| FloatToBoolean | target | The range to update. |

#### SetDirectionExtractorSource(GameObject)

Sets the source of the direction extractor.

##### Declaration

```
public virtual void SetDirectionExtractorSource(GameObject source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GameObject | source | The GameObject for the source. |

#### SetHorizontalDeadzone(FloatRange)

Sets the Horizontal Deadzone.

##### Declaration

```
public virtual void SetHorizontalDeadzone(FloatRange source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | source | The FloatRange for the deadzone. |

#### SetHorizontalInputSource(FloatAction)

Adds the given source to the [HorizontalAxis] Sources collection.

##### Declaration

```
public virtual void SetHorizontalInputSource(FloatAction source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | source | The FloatAction to add to the Sources collection. |

#### SetInputSource(FloatAction, FloatAction)

Sets the adds the source to the Sources collection of the target FloatAction.

##### Declaration

```
protected virtual void SetInputSource(FloatAction source, FloatAction target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | source | The FloatAction to add as a source. |
| FloatAction | target | The FloatAction to have the Sources collection updated. |

#### SetVerticalDeadzone(FloatRange)

Sets the Vertical Deadzone.

##### Declaration

```
public virtual void SetVerticalDeadzone(FloatRange source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | source | The FloatRange for the deadzone. |

#### SetVerticalInputSource(FloatAction)

Adds the given source to the [VerticalAxis] Sources collection.

##### Declaration

```
public virtual void SetVerticalInputSource(FloatAction source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | source | The FloatAction to add to the Sources collection. |

[Tilia.Input.CombinedActions]: README.md
[HorizontalAxis]: AxesToAngleActionConfigurator.md#HorizontalAxis
[VerticalAxis]: AxesToAngleActionConfigurator.md#VerticalAxis
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AngleConverter]: #AngleConverter
[DirectionExtractor]: #DirectionExtractor
[HorizontalAxis]: #HorizontalAxis
[HorizontalDeadZone]: #HorizontalDeadZone
[VerticalAxis]: #VerticalAxis
[VerticalDeadZone]: #VerticalDeadZone
[Methods]: #Methods
[SetDeadzone(FloatRange, FloatToBoolean)]: #SetDeadzoneFloatRange-FloatToBoolean
[SetDirectionExtractorSource(GameObject)]: #SetDirectionExtractorSourceGameObject
[SetHorizontalDeadzone(FloatRange)]: #SetHorizontalDeadzoneFloatRange
[SetHorizontalInputSource(FloatAction)]: #SetHorizontalInputSourceFloatAction
[SetInputSource(FloatAction, FloatAction)]: #SetInputSourceFloatAction-FloatAction
[SetVerticalDeadzone(FloatRange)]: #SetVerticalDeadzoneFloatRange
[SetVerticalInputSource(FloatAction)]: #SetVerticalInputSourceFloatAction
