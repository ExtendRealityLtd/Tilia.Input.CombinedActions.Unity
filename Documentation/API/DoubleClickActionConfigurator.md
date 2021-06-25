# Class DoubleClickActionConfigurator

Sets up the DoubleClickAction prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ClickTimer]
  * [DoubleClickAction]
  * [Facade]
  * [FirstClickAction]
  * [OutputAction]
  * [SecondClickAction]
* [Methods]
  * [ConfigureClickTimer(Single)]
  * [ConfigureSourceClickAction(BooleanAction)]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* DoubleClickActionConfigurator

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class DoubleClickActionConfigurator : MonoBehaviour
```

### Properties

#### ClickTimer

The CountdownTimer that handles the delay between clicks.

##### Declaration

```
public CountdownTimer ClickTimer { get; protected set; }
```

#### DoubleClickAction

The BooleanAction that handles the final double click state.

##### Declaration

```
public BooleanAction DoubleClickAction { get; protected set; }
```

#### Facade

The public interface facade.

##### Declaration

```
public DoubleClickActionFacade Facade { get; protected set; }
```

#### FirstClickAction

The BooleanAction that handles the first click state.

##### Declaration

```
public BooleanAction FirstClickAction { get; protected set; }
```

#### OutputAction

The BooleanAction that handles the final output state.

##### Declaration

```
public BooleanAction OutputAction { get; protected set; }
```

#### SecondClickAction

The BooleanAction that handles the second click state.

##### Declaration

```
public BooleanAction SecondClickAction { get; protected set; }
```

### Methods

#### ConfigureClickTimer(Single)

Configures the timer for the monitored delay between clicks.

##### Declaration

```
public virtual void ConfigureClickTimer(float clickDuration)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | clickDuration | The duration in which the double click must take place. |

#### ConfigureSourceClickAction(BooleanAction)

Configures the source action for the double click to monitor.

##### Declaration

```
public virtual void ConfigureSourceClickAction(BooleanAction source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | source | The source action. |

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.Input.CombinedActions]: README.md
[DoubleClickActionFacade]: DoubleClickActionFacade.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ClickTimer]: #ClickTimer
[DoubleClickAction]: #DoubleClickAction
[Facade]: #Facade
[FirstClickAction]: #FirstClickAction
[OutputAction]: #OutputAction
[SecondClickAction]: #SecondClickAction
[Methods]: #Methods
[ConfigureClickTimer(Single)]: #ConfigureClickTimerSingle
[ConfigureSourceClickAction(BooleanAction)]: #ConfigureSourceClickActionBooleanAction
[OnEnable()]: #OnEnable
