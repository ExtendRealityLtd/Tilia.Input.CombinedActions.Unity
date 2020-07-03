# Changelog

### [1.5.1](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.5.0...v1.5.1) (2020-07-03)

#### Bug Fixes

* **HowToGuides:** apply document style guidelines ([344921c](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/344921cb1e3ddc262d4e16a7bfb335baabeaa33b))
  > The document style guidelines have been applied to clean up the how to guide for this repo.

## [1.5.0](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.4.3...v1.5.0) (2020-07-03)

#### Features

* **API:** add auto-generated API documentation ([493b92f](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/493b92f7a59a9e61539ee8c35051098b1c19ca52))
  > The API documentation is auto generated with docfx and converted to markdown via turndown in a custom nodejs script.

#### Bug Fixes

* **package.json:** add docfx.json file ([9192b23](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/9192b23547089796a62cb7db8feb243955da6bae))
  > The docfx.json file was missing from the package.json causing the build process to fail. It has now been added.

### [1.4.3](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.4.2...v1.4.3) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([439bf00](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/439bf009dccde3a6a854b25208fb7957d1a3cfcf))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.4.2](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.4.1...v1.4.2) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.1 to 1.18.0 ([7cc3546](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/7cc354602408f62aa25c8831579963ad0200dc40))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.1 to 1.18.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.1...v1.18.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.4.1](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.4.0...v1.4.1) (2020-05-28)

#### Bug Fixes

* **Action:** move cleared attribute to correct location ([c443031](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/c44303152d253b053167c893c474c701f744a320))
  > The Cleared attribute was in the field location and therefore was not creating the correct Clear method for the property and instead was creating it for the backing field.

## [1.4.0](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.3.1...v1.4.0) (2020-05-25)

#### Features

* **AngleRangeToBoolean:** add change angle unit and higher angle range ([0e7e1bc](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/0e7e1bc65500387985b10345908a7d493c73077c))
  > The angle unit can now be changed via the inspector and the angle range can extend between -360f and 360f to ensure all angle unit types can be catered for.
  > 
  > This now makes it possible to get a downward angle, which would be in degrees (or radians) at 170 degrees <--> 200 degress, whereas this isn't possible with signed units as -180 degress is the far left and 180 is the far right, but there is no simple way of knowing the down without using the unsigned unit type.
* **AxisToAngle:** include Vector2ToAngle component in configuration ([38c82d8](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/38c82d8df27a4d6a466399ff2ac6c49eba7b7d58))
  > Adding the Vector2ToAngle angle converter to the configuration makes it easier to access this component externally.

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.3.0...v1.3.1) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.0 to 1.17.1 ([c58a89c](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/c58a89c716a2782a9406bbfdf8445e5889fda8d7))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.0 to 1.17.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.0...v1.17.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.2.4...v1.3.0) (2020-05-22)

#### Features

* **Action:** convert angle range to boolean ([eac0167](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/eac016782567ad3ee9d021a78d4d2982bce23260))
  > The AngleRangeToBoolean prefab utilizes an AxesToAngleAction to convert a axis data to an angle and then to determine if that angle is within the angle range and setting a boolean action appropriately.
  > 
  > There are two output boolean actions included with the prefab:
  > 
  > * `DeactivateOutsideOfAngleRange` - will deactivate the boolean when the current angle is no longer in the set range. * `DeactivateWithinAxisDeadzone` - the action will activate when the angle is within the set range but will not deactivate when the angle is no longer in the set range and will only deactivate when the axis falls back within the deadzone.
* **AxesToAngleAction:** provide direction offset ([56db138](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/56db13894e2c8d7c2f213a4081a61086fcd3af2a))
  > The Direction Offset property allows a GameObject to be provided that will be used to set the origin on the Vector2ToAngle component to ensure the angle is offset based on the direction of the offset.

### [1.2.4](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.2.3...v1.2.4) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.16.0 to 1.17.0 ([b10067b](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/b10067b7c33d0c324bea68c4bedcacb1f481bf42))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.16.0 to 1.17.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.16.0...v1.17.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.3](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.2.2...v1.2.3) (2020-04-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.15.0 to 1.16.0 ([7f69d37](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/7f69d37e15e74a2b543c8adb0e12eac018597afb))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.15.0 to 1.16.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.15.0...v1.16.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.2](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.2.1...v1.2.2) (2020-04-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.14.1 to 1.15.0 ([efaf247](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/efaf247aac65339c2c4543f81ee51f75bd774afe))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.1 to 1.15.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.1...v1.15.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.1](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.2.0...v1.2.1) (2020-04-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.14.0 to 1.14.1 ([a7e4939](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/a7e493970ce9aa0ae17e322a60f7725c03f968d4))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.0 to 1.14.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.0...v1.14.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.1.0...v1.2.0) (2020-03-12)

#### Features

* **HowToGuides:** using combined actions ([a715563](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/a71556335174acecf20d0d67621aec61d0ff4d3b))
  > added guide for showing how to use combined actions.

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.0.1...v1.1.0) (2020-03-07)

#### Features

* **Action:** convert axis data to float angle with deadzone limits ([f1fd5c5](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/f1fd5c54dd2a0bb2faca223dadb7e98d133b8e46))
  > The AxesToAngleAction takes a horizontal and vertical axis and converts it to an angle which can be used to determine the direction in which a 2d axis is being pushed. The angle output can then be fed into something to provide an action such as rotating the object to face in a certain direction.

#### Bug Fixes

* **Action:** ensure object properties can be cleared ([dc5d0a5](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/dc5d0a5f0494ee56487fb658240f96c75497ebf1))
  > The object properties have now been annotated with the Cleared attribute so the relevant cleared method will be weaved for these object properties.

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.0.0...v1.0.1) (2020-03-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.13.0 to 1.14.0 ([f5e71f7](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/f5e71f7e5aa05402dad922c07143da827b25e4b0))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.13.0 to 1.14.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.13.0...v1.14.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## 1.0.0 (2020-03-03)

#### Features

* **structure:** create initial prefabs and documentation ([8aab478](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/commit/8aab47833fd964781cff3355d8b361c4ab9a6e02))
  > The initial prefabs and relevant documentation for the CombinedActions has been added to the repo.
