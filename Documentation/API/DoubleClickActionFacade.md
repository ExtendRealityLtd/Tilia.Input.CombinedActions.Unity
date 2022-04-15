# Class DoubleClickActionFacade

Controls the BooleanAction state based on whether the given input action has been activated twice within a given period of time.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ClickDuration]
  * [Configuration]
  * [ControlAction]
* [Methods]
  * [ClearControlAction()]
  * [OnAfterClickDurationChange()]
  * [OnAfterControlActionChange()]

## Details

##### Inheritance

* System.Object
* DoubleClickActionFacade

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class DoubleClickActionFacade : MonoBehaviour
```

### Properties

#### ClickDuration

The time between each click can occur to expect the double click action to execute.

##### Declaration

```
public float ClickDuration { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public DoubleClickActionConfigurator Configuration { get; protected set; }
```

#### ControlAction

The BooleanAction that controls the double click action.

##### Declaration

```
public BooleanAction ControlAction { get; set; }
```

### Methods

#### ClearControlAction()

Clears [ControlAction].

##### Declaration

```
public virtual void ClearControlAction()
```

#### OnAfterClickDurationChange()

Called after [ClickDuration] has been changed.

##### Declaration

```
protected virtual void OnAfterClickDurationChange()
```

#### OnAfterControlActionChange()

Called after [ControlAction] has been changed.

##### Declaration

```
protected virtual void OnAfterControlActionChange()
```

[Tilia.Input.CombinedActions]: README.md
[DoubleClickActionConfigurator]: DoubleClickActionConfigurator.md
[ControlAction]: DoubleClickActionFacade.md#ControlAction
[ClickDuration]: DoubleClickActionFacade.md#ClickDuration
[ControlAction]: DoubleClickActionFacade.md#ControlAction
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ClickDuration]: #ClickDuration
[Configuration]: #Configuration
[ControlAction]: #ControlAction
[Methods]: #Methods
[ClearControlAction()]: #ClearControlAction
[OnAfterClickDurationChange()]: #OnAfterClickDurationChange
[OnAfterControlActionChange()]: #OnAfterControlActionChange
