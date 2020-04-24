<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /readme.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# <img src="/src/icon.png" height="30px"> DiffEngine

[![Build status](https://ci.appveyor.com/api/projects/status/b62ti1b998iy3njw/branch/master?svg=true)](https://ci.appveyor.com/project/SimonCropp/DiffEngine)
[![NuGet Status](https://img.shields.io/nuget/v/DiffEngine.svg)](https://www.nuget.org/packages/DiffEngine/)

DiffEngine manages launching and cleanup of diff tools. It is designed to be used by any Snapshot/Approval testing library.

**Currently used by:**

 * [ApprovalTests](https://github.com/approvals/ApprovalTests.Net)
 * [Verify](https://github.com/SimonCropp/Verify)


Support is available via [Tidelift](https://tidelift.com/subscription/pkg/nuget-diffengine?utm_source=nuget-diffengine&utm_medium=referral&utm_campaign=enterprise).

<!-- toc -->
## Contents

  * [NuGet package](#nuget-package)
  * [Supported Tools](#supported-tools)
  * [Launching a tool](#launching-a-tool)
  * [Closing a tool](#closing-a-tool)
  * [File type detection](#file-type-detection)
  * [BuildServerDetector](#buildserverdetector)
  * [Security contact information](#security-contact-information)<!-- endtoc -->
  * [Tools](/docs/diff-tool.md) <!-- include: doc-index. path: /docs/mdsource/doc-index.include.md -->
  * [Tool Order](/docs/diff-tool.order.md)
  * [Custom Tool](/docs/diff-tool.custom.md) <!-- end include: doc-index. path: /docs/mdsource/doc-index.include.md -->


## NuGet package

 * https://nuget.org/packages/DiffEngine/


## [Supported Tools](/docs/diff-tool.md#supported-tools)

 * [AraxisMerge](/docs/diff-tool.md#araxismerge) <!-- include: diffToolList. path: /src/DiffEngine.Tests/diffToolList.include.md -->
 * [BeyondCompare](/docs/diff-tool.md#beyondcompare)
 * [CodeCompare](/docs/diff-tool.md#codecompare)
 * [DeltaWalker](/docs/diff-tool.md#deltawalker)
 * [DiffMerge](/docs/diff-tool.md#diffmerge)
 * [Kaleidoscope](/docs/diff-tool.md#kaleidoscope)
 * [KDiff3](/docs/diff-tool.md#kdiff3)
 * [Meld](/docs/diff-tool.md#meld)
 * [P4Merge](/docs/diff-tool.md#p4merge)
 * [Rider](/docs/diff-tool.md#rider)
 * [SublimeMerge](/docs/diff-tool.md#sublimemerge)
 * [TkDiff](/docs/diff-tool.md#tkdiff)
 * [TortoiseGitMerge](/docs/diff-tool.md#tortoisegitmerge)
 * [TortoiseIDiff](/docs/diff-tool.md#tortoiseidiff)
 * [TortoiseMerge](/docs/diff-tool.md#tortoisemerge)
 * [VisualStudio](/docs/diff-tool.md#visualstudio)
 * [VisualStudioCode](/docs/diff-tool.md#visualstudiocode)
 * [WinMerge](/docs/diff-tool.md#winmerge) <!-- end include: diffToolList. path: /src/DiffEngine.Tests/diffToolList.include.md -->


## Launching a tool

A tool can be launched using the following:

<!-- snippet: DiffRunnerLaunch -->
<a id='snippet-diffrunnerlaunch'/></a>
```cs
DiffRunner.Launch(tempFile, targetFile);
```
<sup><a href='/src/DiffEngine.Tests/DiffRunnerTests.cs#L18-L20' title='File snippet `diffrunnerlaunch` was extracted from'>snippet source</a> | <a href='#snippet-diffrunnerlaunch' title='Navigate to start of snippet `diffrunnerlaunch`'>anchor</a></sup>
<!-- endsnippet -->

Note that this method will respect the above [difference behavior](/docs/diff-tool.md#detected-difference-behavior) in terms of Auto refresh and MDI behaviors.


## Closing a tool

A tool can be closed using the following:

<!-- snippet: DiffRunnerKill -->
<a id='snippet-diffrunnerkill'/></a>
```cs
DiffRunner.Kill(tempFile, targetFile);
```
<sup><a href='/src/DiffEngine.Tests/DiffRunnerTests.cs#L29-L31' title='File snippet `diffrunnerkill` was extracted from'>snippet source</a> | <a href='#snippet-diffrunnerkill' title='Navigate to start of snippet `diffrunnerkill`'>anchor</a></sup>
<!-- endsnippet -->

Note that this method will respect the above [difference behavior](/docs/diff-tool.md#detected-difference-behavior) in terms of MDI behavior.


## File type detection

DiffEngine use [EmptyFiles](https://github.com/SimonCropp/EmptyFiles) to determine if a given file or extension is a binary or text.


## BuildServerDetector

`BuildServerDetector.Detected` returns true if the current code is running on a build/CI server.

Supports:

 * [AppVeyor](https://www.appveyor.com/docs/environment-variables/)
 * [Travis](https://docs.travis-ci.com/user/environment-variables/#default-environment-variables)
 * [Jenkins](https://wiki.jenkins.io/display/JENKINS/Building+a+software+project#Buildingasoftwareproject-belowJenkinsSetEnvironmentVariables)
 * [GitHub Actions](https://help.github.com/en/actions/automating-your-workflow-with-github-actions/using-environment-variables#default-environment-variables)
 * [AzureDevops](https://docs.microsoft.com/en-us/azure/devops/pipelines/build/variables?view=azure-devops&tabs=yaml#agent-variables)
 * [TeamCity](https://www.jetbrains.com/help/teamcity/predefined-build-parameters.html#PredefinedBuildParameters-ServerBuildProperties)


## Security contact information

To report a security vulnerability, use the [Tidelift security contact](https://tidelift.com/security). Tidelift will coordinate the fix and disclosure.


## Icon

[Engine](https://thenounproject.com/term/engine/2499554/) designed by [Eucalyp](https://thenounproject.com/eucalyp) from [The Noun Project](https://thenounproject.com).
