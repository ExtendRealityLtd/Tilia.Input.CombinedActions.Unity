# Class AxesToVector3ActionConfigurator

Sets up the AxesToVector3Action prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AutoConfigureBounds]
  * [BoundOverlap]
  * [CombinedAxisDeadzoneContainer]
  * [DirectionalContainer]
  * [IncrementalContainer]
  * [LateralAction]
  * [LateralBoundsManager]
  * [LateralDeadZone]
  * [LateralNegativeBounds]
  * [LateralPositiveBounds]
  * [LongitudinalAction]
  * [LongitudinalBoundsManager]
  * [LongitudinalDeadZone]
  * [LongitudinalNegativeBounds]
  * [LongitudinalPositiveBounds]
  * [Multiplier]
  * [SingleAxisDeadzoneContainer]
  * [TimeExtractor]
  * [VerticalAction]
  * [VerticalBoundsManager]
  * [VerticalDeadZone]
  * [VerticalNegativeBounds]
  * [VerticalPositiveBounds]
* [Methods]
  * [SetBounds(FloatRange, FloatToBoolean\[\], FloatToBoolean, FloatToBoolean, FloatToBoolean)]
  * [SetDeadzoneCalculation(AxesToVector3Action.DeadzoneType)]
  * [SetInputSource(FloatAction, FloatAction)]
  * [SetInputType(AxesToVector3Action.InputHandler)]
  * [SetLateralAxisSource(FloatAction)]
  * [SetLateralDeadzone(FloatRange)]
  * [SetLongitudinalAxisSource(FloatAction)]
  * [SetLongitudinalDeadzone(FloatRange)]
  * [SetMultiplier(Vector3)]
  * [SetTimeMultiplier(TimeComponentExtractor.TimeComponent)]
  * [SetVerticalAxisSource(FloatAction)]
  * [SetVerticalDeadzone(FloatRange)]

## Details

##### Inheritance

* System.Object
* AxesToVector3ActionConfigurator

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class AxesToVector3ActionConfigurator : MonoBehaviour
```

### Properties

#### AutoConfigureBounds

Whether to automatically configure the deadzones and axis bounds.

##### Declaration

```
public bool AutoConfigureBounds { get; set; }
```

#### BoundOverlap

The value to overlap the directional input bounds by.

##### Declaration

```
public float BoundOverlap { get; set; }
```

#### CombinedAxisDeadzoneContainer

The container that holds the combined axis deadzone logic.

##### Declaration

```
public GameObject CombinedAxisDeadzoneContainer { get; set; }
```

#### DirectionalContainer

The container that holds the directional input logic.

##### Declaration

```
public GameObject DirectionalContainer { get; set; }
```

#### IncrementalContainer

The container that holds the incremental input logic.

##### Declaration

```
public GameObject IncrementalContainer { get; set; }
```

#### LateralAction

The FloatAction representing the Lateral (X Axis)\[left/right\].

##### Declaration

```
public FloatAction LateralAction { get; set; }
```

#### LateralBoundsManager

The lateral bounds manager.

##### Declaration

```
public FloatToBoolean LateralBoundsManager { get; set; }
```

#### LateralDeadZone

The lateral deadzone controller.

##### Declaration

```
public FloatToBoolean[] LateralDeadZone { get; set; }
```

#### LateralNegativeBounds

The lateral negative bounds controller.

##### Declaration

```
public FloatToBoolean LateralNegativeBounds { get; set; }
```

#### LateralPositiveBounds

The lateral positive bounds controller.

##### Declaration

```
public FloatToBoolean LateralPositiveBounds { get; set; }
```

#### LongitudinalAction

The FloatAction representing the Longitudinal (Z Axis)\[forward/backward\].

##### Declaration

```
public FloatAction LongitudinalAction { get; set; }
```

#### LongitudinalBoundsManager

The longitudinal bounds manager.

##### Declaration

```
public FloatToBoolean LongitudinalBoundsManager { get; set; }
```

#### LongitudinalDeadZone

The longitudinal deadzone controller.

##### Declaration

```
public FloatToBoolean[] LongitudinalDeadZone { get; set; }
```

#### LongitudinalNegativeBounds

The longitudinal negative bounds controller.

##### Declaration

```
public FloatToBoolean LongitudinalNegativeBounds { get; set; }
```

#### LongitudinalPositiveBounds

The longitudinal positive bounds controller.

##### Declaration

```
public FloatToBoolean LongitudinalPositiveBounds { get; set; }
```

#### Multiplier

The collection used to multiply the output Vector3.

##### Declaration

```
public Vector3ObservableList Multiplier { get; set; }
```

#### SingleAxisDeadzoneContainer

The container that holds the single axis deadzone logic.

##### Declaration

```
public GameObject SingleAxisDeadzoneContainer { get; set; }
```

#### TimeExtractor

Extracts a Time component.

##### Declaration

```
public TimeComponentExtractor TimeExtractor { get; set; }
```

#### VerticalAction

The FloatAction representing the Vertical (Y Axis)\[up/down\].

##### Declaration

```
public FloatAction VerticalAction { get; set; }
```

#### VerticalBoundsManager

The vertical bounds manager.

##### Declaration

```
public FloatToBoolean VerticalBoundsManager { get; set; }
```

#### VerticalDeadZone

The vertical deadzone controller.

##### Declaration

```
public FloatToBoolean[] VerticalDeadZone { get; set; }
```

#### VerticalNegativeBounds

The vertical negative bounds controller.

##### Declaration

```
public FloatToBoolean VerticalNegativeBounds { get; set; }
```

#### VerticalPositiveBounds

The vertical positive bounds controller.

##### Declaration

```
public FloatToBoolean VerticalPositiveBounds { get; set; }
```

### Methods

#### SetBounds(FloatRange, FloatToBoolean\[\], FloatToBoolean, FloatToBoolean, FloatToBoolean)

Sets the boundary data for the input.

##### Declaration

```
protected virtual void SetBounds(FloatRange newBounds, FloatToBoolean[] deadzone, FloatToBoolean positiveBounds, FloatToBoolean negativeBounds, FloatToBoolean boundsManager)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | newBounds | Thew new range for the bounds. |
| FloatToBoolean\[\] | deadzone | The axis deadzone to set. |
| FloatToBoolean | positiveBounds | The axis positive bounds to set. |
| FloatToBoolean | negativeBounds | The axis negative bounds to set. |
| FloatToBoolean | boundsManager | The axis bounds manager to set. |

#### SetDeadzoneCalculation(AxesToVector3Action.DeadzoneType)

Enables the appropriate Deadzone Calculation logic.

##### Declaration

```
public virtual void SetDeadzoneCalculation(AxesToVector3Action.DeadzoneType deadzoneType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [AxesToVector3Action.DeadzoneType] | deadzoneType | The type of deadzone to use. |

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

#### SetInputType(AxesToVector3Action.InputHandler)

Sets the state of the relevant input type GameObjects.

##### Declaration

```
public virtual void SetInputType(AxesToVector3Action.InputHandler inputType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [AxesToVector3Action.InputHandler] | inputType | The current input type to use. |

#### SetLateralAxisSource(FloatAction)

Adds the given source to the [LateralAction] Sources collection.

##### Declaration

```
public virtual void SetLateralAxisSource(FloatAction source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | source | The FloatAction to add to the Sources collection. |

#### SetLateralDeadzone(FloatRange)

Sets the deadzone for the lateral axis.

##### Declaration

```
public virtual void SetLateralDeadzone(FloatRange deadzone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | deadzone | The deadzone range to set to. |

#### SetLongitudinalAxisSource(FloatAction)

Adds the given source to the [LongitudinalAction] Sources collection.

##### Declaration

```
public virtual void SetLongitudinalAxisSource(FloatAction source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | source | The FloatAction to add to the Sources collection. |

#### SetLongitudinalDeadzone(FloatRange)

Sets the deadzone for the longitudinal axis.

##### Declaration

```
public virtual void SetLongitudinalDeadzone(FloatRange deadzone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | deadzone | The deadzone range to set to. |

#### SetMultiplier(Vector3)

Sets the output multiplier.

##### Declaration

```
public virtual void SetMultiplier(Vector3 multiplier)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Vector3 | multiplier | The new multiplier to use. |

#### SetTimeMultiplier(TimeComponentExtractor.TimeComponent)

Sets the Time source type to multiply by.

##### Declaration

```
public virtual void SetTimeMultiplier(TimeComponentExtractor.TimeComponent component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TimeComponentExtractor.TimeComponent | component | The component to multiply by. |

#### SetVerticalAxisSource(FloatAction)

Adds the given source to the [VerticalAction] Sources collection.

##### Declaration

```
public virtual void SetVerticalAxisSource(FloatAction source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | source | The FloatAction to add to the Sources collection. |

#### SetVerticalDeadzone(FloatRange)

Sets the deadzone for the vertical axis.

##### Declaration

```
public virtual void SetVerticalDeadzone(FloatRange deadzone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | deadzone | The deadzone range to set to. |

[Tilia.Input.CombinedActions]: README.md
[AxesToVector3Action.DeadzoneType]: AxesToVector3Action.DeadzoneType.md
[AxesToVector3Action.InputHandler]: AxesToVector3Action.InputHandler.md
[LateralAction]: AxesToVector3ActionConfigurator.md#LateralAction
[LongitudinalAction]: AxesToVector3ActionConfigurator.md#LongitudinalAction
[VerticalAction]: AxesToVector3ActionConfigurator.md#VerticalAction
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AutoConfigureBounds]: #AutoConfigureBounds
[BoundOverlap]: #BoundOverlap
[CombinedAxisDeadzoneContainer]: #CombinedAxisDeadzoneContainer
[DirectionalContainer]: #DirectionalContainer
[IncrementalContainer]: #IncrementalContainer
[LateralAction]: #LateralAction
[LateralBoundsManager]: #LateralBoundsManager
[LateralDeadZone]: #LateralDeadZone
[LateralNegativeBounds]: #LateralNegativeBounds
[LateralPositiveBounds]: #LateralPositiveBounds
[LongitudinalAction]: #LongitudinalAction
[LongitudinalBoundsManager]: #LongitudinalBoundsManager
[LongitudinalDeadZone]: #LongitudinalDeadZone
[LongitudinalNegativeBounds]: #LongitudinalNegativeBounds
[LongitudinalPositiveBounds]: #LongitudinalPositiveBounds
[Multiplier]: #Multiplier
[SingleAxisDeadzoneContainer]: #SingleAxisDeadzoneContainer
[TimeExtractor]: #TimeExtractor
[VerticalAction]: #VerticalAction
[VerticalBoundsManager]: #VerticalBoundsManager
[VerticalDeadZone]: #VerticalDeadZone
[VerticalNegativeBounds]: #VerticalNegativeBounds
[VerticalPositiveBounds]: #VerticalPositiveBounds
[Methods]: #Methods
[SetBounds(FloatRange, FloatToBoolean\[\], FloatToBoolean, FloatToBoolean, FloatToBoolean)]: #SetBoundsFloatRange-FloatToBoolean\[\]-FloatToBoolean-FloatToBoolean-FloatToBoolean
[SetDeadzoneCalculation(AxesToVector3Action.DeadzoneType)]: #SetDeadzoneCalculationAxesToVector3Action.DeadzoneType
[SetInputSource(FloatAction, FloatAction)]: #SetInputSourceFloatAction-FloatAction
[SetInputType(AxesToVector3Action.InputHandler)]: #SetInputTypeAxesToVector3Action.InputHandler
[SetLateralAxisSource(FloatAction)]: #SetLateralAxisSourceFloatAction
[SetLateralDeadzone(FloatRange)]: #SetLateralDeadzoneFloatRange
[SetLongitudinalAxisSource(FloatAction)]: #SetLongitudinalAxisSourceFloatAction
[SetLongitudinalDeadzone(FloatRange)]: #SetLongitudinalDeadzoneFloatRange
[SetMultiplier(Vector3)]: #SetMultiplierVector3
[SetTimeMultiplier(TimeComponentExtractor.TimeComponent)]: #SetTimeMultiplierTimeComponentExtractor.TimeComponent
[SetVerticalAxisSource(FloatAction)]: #SetVerticalAxisSourceFloatAction
[SetVerticalDeadzone(FloatRange)]: #SetVerticalDeadzoneFloatRange
