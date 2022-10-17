# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
### Added
- Add "reject_duplicates" flag to document upload endpoint
- Add "reject_duplicates" flag to document upload endpoint

### Changed
- Modify document upload endpoint parameters
- Modify document upload endpoint parameters

## [2.3.1] - 2022-09-23
### Changed
- Update API spec to match API response.

## [2.3.0] - 2022-09-20
### Added
- Add job description search config and embed endpoints
- Update index endpoint with document type parameter

## [2.2.0] - 2022-08-25
### Changed
- Update modelerfour version to latest
- Updated azure core libary to 1.25.0
- fixed typing of some endpoint objects

### Deprecated
- Depreciated resume_formats and reformatted_resumes endpoints

### Added
- Reverse match functionality - search job descriptions with a resume, or with a set of parameters.

## [2.1.0] - 2022-07-08
### Added
- Add line item tables and an ability to update resume data in the search system, and endpoint for managing user accounts

## [2.0.3] - 2022-05-01
### Added
- Add review URL in the invoice response that allows embedding of the Affinda Invoice Review UI

## [2.0.2] - 2022-04-29
### Added
- Fix text annots

## [2.0.1] - 2022-04-29
### Added
- Fix annotation parsed types

## [2.0.0] - 2022-04-29
### Added
- Add Job description parsing and update invoices output to include rectangle locations and confidence levels

## [1.3.0] - 2022-04-13
### Changed
- Update autorest depedencies

## [1.2.2] - 2022-03-25
### Changed
- Add iso 3166 country code to locations

## [1.2.1] - 2021-12-09
### Added
- Adding Occupation to work experience.  Includes SOC2020 classifications and management level.  Job titles are normalized against EMSI taxonomy'

## [1.2.0] - 2021-10-06
### Added
- Invoices endpoint

### Removed
- Removed 'url' format from url strings in api spec

## [1.1.1] - 2021-09-30
### Changed
- Updating readme and changelog for automated builds

## [1.1.0] - 2021-09-16
### Fixed
- Small fixes

## [1.0.1] - 2021-09-15
### Added
- Adding LinkedIn to ResumeData

### Fixed
- Fixed dependencies and README install directions

## [1.0.0] - 2021-09-08
* Initial release

