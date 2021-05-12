[![Tilia logo][Tilia-Image]](#)

> ### Input -> Combined Actions for the Unity Software
> {A collection of custom actions that combine sub actions into more complex action types for the Unity software.

[![Release][Version-Release]][Releases]
[![License][License-Badge]][License]
[![Backlog][Backlog-Badge]][Backlog]

## Introduction

Combined Actions are a collection of useful prefabs that utilize simple actions in different combinations to provide more complex action systems for the [Unity] software.

Included actions are:

* `BooleanTo1DAxisAction` - Uses two Boolean Actions that represent the positive and negative upper limits of an axis to create a psuedo `-1f` to `1f` range Float Action axis.
* `AxesToVector3Action` - Uses up to three Float Actions that represent the lateral, vertical and longitudinal axes and converts into a Vector3 Action of the axis data.

> **Requires** the Unity software version `2018.3.10f1` (or above).

## Getting Started

Please refer to the [installation] guide to install this package.

## Documentation

Please refer to the [How To Guides] for usage of this package.

Further documentation can be found within the [Documentation] directory and at https://academy.vrtk.io

## Contributing

Please refer to the Extend Reality [Contributing guidelines] and the [project coding conventions].

## Code of Conduct

Please refer to the Extend Reality [Code of Conduct].

## License

Code released under the [MIT License][License].

[License-Badge]: https://img.shields.io/github/license/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity.svg
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity.svg
[project coding conventions]: https://github.com/ExtendRealityLtd/.github/blob/master/CONVENTIONS/UNITY3D.md

[Tilia-Image]: https://raw.githubusercontent.com/ExtendRealityLtd/related-media/main/github/readme/tilia.png
[License]: LICENSE.md
[Documentation]: Documentation/
[How To Guides]: Documentation/HowToGuides/
[Installation]: Documentation/HowToGuides/Installation/README.md
[Backlog]: http://tracker.vrtk.io
[Backlog-Badge]: https://img.shields.io/badge/project-backlog-78bdf2.svg
[Releases]: ../../releases
[Contributing guidelines]: https://github.com/ExtendRealityLtd/.github/blob/master/CONTRIBUTING.md
[Code of Conduct]: https://github.com/ExtendRealityLtd/.github/blob/master/CODE_OF_CONDUCT.md

[Unity]: https://unity3d.com/