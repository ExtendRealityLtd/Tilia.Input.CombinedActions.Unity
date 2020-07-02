# Class BooleanTo1DAxisActionConfigurator

Sets up the BooleanTo1DAxisAction prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [NegativeInput]
  * [PositiveInput]
* [Methods]
  * [SetInputSource(BooleanAction, BooleanAction)]
  * [SetNegativeInputSource(BooleanAction)]
  * [SetPositiveInputSource(BooleanAction)]

## Details

##### Inheritance

* System.Object
* BooleanTo1DAxisActionConfigurator

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class BooleanTo1DAxisActionConfigurator : MonoBehaviour
```

### Properties

#### NegativeInput

The BooleanAction that represents the negative direction of the Axis.

##### Declaration

```
public BooleanAction NegativeInput { get; set; }
```

#### PositiveInput

The BooleanAction that represents the positive direction of the Axis.

##### Declaration

```
public BooleanAction PositiveInput { get; set; }
```

### Methods

#### SetInputSource(BooleanAction, BooleanAction)

Sets the adds the source to the Sources collection of the target BooleanAction.

##### Declaration

```
protected virtual void SetInputSource(BooleanAction source, BooleanAction target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | source | The BooleanAction to add as a source. |
| BooleanAction | target | The BooleanAction to have the Sources collection updated. |

#### SetNegativeInputSource(BooleanAction)

Adds the given source to the [NegativeInput] Sources collection.

##### Declaration

```
public virtual void SetNegativeInputSource(BooleanAction source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | source | The BooleanAction to add to the Sources collection. |

#### SetPositiveInputSource(BooleanAction)

Adds the given source to the [PositiveInput] Sources collection.

##### Declaration

```
public virtual void SetPositiveInputSource(BooleanAction source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | source | The BooleanAction to add to the Sources collection. |

[Tilia.Input.CombinedActions]: README.md
[NegativeInput]: BooleanTo1DAxisActionConfigurator.md#NegativeInput
[PositiveInput]: BooleanTo1DAxisActionConfigurator.md#PositiveInput
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[NegativeInput]: #NegativeInput
[PositiveInput]: #PositiveInput
[Methods]: #Methods
[SetInputSource(BooleanAction, BooleanAction)]: #SetInputSourceBooleanAction-BooleanAction
[SetNegativeInputSource(BooleanAction)]: #SetNegativeInputSourceBooleanAction
[SetPositiveInputSource(BooleanAction)]: #SetPositiveInputSourceBooleanAction
