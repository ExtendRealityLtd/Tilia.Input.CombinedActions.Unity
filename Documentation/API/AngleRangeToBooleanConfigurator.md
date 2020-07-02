# Class AngleRangeToBooleanConfigurator

Sets up the AngleRangeToBoolean Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AngleChecker]
  * [AngleInput]
  * [Facade]
* [Methods]
  * [ConfigureAngleChecker()]
  * [ConfigureAngleInput()]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* AngleRangeToBooleanConfigurator

##### Namespace

* [Tilia.Input.CombinedActions]

##### Syntax

```
public class AngleRangeToBooleanConfigurator : MonoBehaviour
```

### Properties

#### AngleChecker

The FloatToBoolean for checking the angle states.

##### Declaration

```
public FloatToBoolean AngleChecker { get; protected set; }
```

#### AngleInput

The [AxesToAngleAction] getting the input angle.

##### Declaration

```
public AxesToAngleAction AngleInput { get; protected set; }
```

#### Facade

The public interface facade.

##### Declaration

```
public AngleRangeToBooleanFacade Facade { get; protected set; }
```

### Methods

#### ConfigureAngleChecker()

Configures the [AngleChecker] properties.

##### Declaration

```
public virtual void ConfigureAngleChecker()
```

#### ConfigureAngleInput()

Configures the [AngleInput] properties.

##### Declaration

```
public virtual void ConfigureAngleInput()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.Input.CombinedActions]: README.md
[AxesToAngleAction]: AxesToAngleAction.md
[AngleRangeToBooleanFacade]: AngleRangeToBooleanFacade.md
[AngleChecker]: AngleRangeToBooleanConfigurator.md#AngleChecker
[AngleInput]: AngleRangeToBooleanConfigurator.md#AngleInput
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AngleChecker]: #AngleChecker
[AngleInput]: #AngleInput
[Facade]: #Facade
[Methods]: #Methods
[ConfigureAngleChecker()]: #ConfigureAngleChecker
[ConfigureAngleInput()]: #ConfigureAngleInput
[OnEnable()]: #OnEnable
