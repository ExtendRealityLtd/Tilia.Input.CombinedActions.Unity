# Class BooleanTo1DAxisAction

Converts a positive and negative boolean representation into a 1D axis float action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [NegativeInput]
  * [PositiveInput]
* [Methods]
  * [ClearNegativeInput()]
  * [ClearPositiveInput()]
  * [OnAfterNegativeInputChange()]
  * [OnAfterPositiveInputChange()]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* BooleanTo1DAxisAction

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class BooleanTo1DAxisAction : FloatAction
```

### Properties

#### Configuration

The linked Internal Setup.

##### Declaration

```
public BooleanTo1DAxisActionConfigurator Configuration { get; protected set; }
```

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

#### ClearNegativeInput()

Clears [NegativeInput].

##### Declaration

```
public virtual void ClearNegativeInput()
```

#### ClearPositiveInput()

Clears [PositiveInput].

##### Declaration

```
public virtual void ClearPositiveInput()
```

#### OnAfterNegativeInputChange()

Called after [NegativeInput] has been changed.

##### Declaration

```
protected virtual void OnAfterNegativeInputChange()
```

#### OnAfterPositiveInputChange()

Called after [PositiveInput] has been changed.

##### Declaration

```
protected virtual void OnAfterPositiveInputChange()
```

#### OnEnable()

##### Declaration

```
protected override void OnEnable()
```

[Tilia.Input.CombinedActions]: README.md
[BooleanTo1DAxisActionConfigurator]: BooleanTo1DAxisActionConfigurator.md
[NegativeInput]: BooleanTo1DAxisAction.md#NegativeInput
[PositiveInput]: BooleanTo1DAxisAction.md#PositiveInput
[NegativeInput]: BooleanTo1DAxisAction.md#NegativeInput
[PositiveInput]: BooleanTo1DAxisAction.md#PositiveInput
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[NegativeInput]: #NegativeInput
[PositiveInput]: #PositiveInput
[Methods]: #Methods
[ClearNegativeInput()]: #ClearNegativeInput
[ClearPositiveInput()]: #ClearPositiveInput
[OnAfterNegativeInputChange()]: #OnAfterNegativeInputChange
[OnAfterPositiveInputChange()]: #OnAfterPositiveInputChange
[OnEnable()]: #OnEnable
