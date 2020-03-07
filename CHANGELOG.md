# Changelog

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
