# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
### Changed
- Allow custom resume fields to be nullable

## [4.3.0] - 2023-04-27
### Changed
- rawText is now not nullable

### Fixed
- Allow rejectDuplicates to be null
- Fixed handling of rejectDuplicates in response objects causing parsing errors

### Added
- Phone number details to Resume Candidate info
- "data" to job description create

## [4.2.1] - 2023-03-30
### Changed
- "Rectangles" attribute in Annotation updates to readonly

## [4.2.0] - 2023-03-15
### Fixed
- Fix JD create/update after v2/v3 split
- Ensure list endpoints have 'results' and 'count' properties required

## [4.1.0] - 2023-03-10
### Fixed
- Fixed GET request array object types for invoices, resumes, redacted resumes and job_descriptions

## [4.0.0] - 2023-03-09
### Added
- Add resthook subscription endpoints
- Added PATCH support for Job Descriptions
- Add `confirmed_by` field to document meta
- Add link to affinda help docs for resthook creation
- Add activate resthook subscription endpoint

### Changed
- Remove extractor's `id` field, use `identifier` field instead
- Rework document polymorphism, the model used to deserialize document response is now automatically chosen based on the document's extractor
- Make Document.Meta.confirmedBy nullable

### Removed
- Remove extractor's `id` field
- Removed v3 endpoints, see newer major release for v3 compatible release

## [3.1.0] - 2023-02-06
### Added
- Add cell to valid content types
- Add EU API server to api docs
- Add latitude and longtitude to Location
- Add expectedremuneration, jobtitle, language, skill and yearsexperience to AnnotationContentType
- re-add DataPoint.simlarTo
- Add `exclude` parameter to /documents query
- add ingest email to Workspace and Collection

### Changed
- Changed Document top level structure to more closely resemble api v2 with top level keys of meta, data and error
- ResumeSearchParamaters.resume, ResumeSearchParameters.jobdescription, JobDescriptionSearchParameters.resume, DataPoint.organization

### Fixed
- Fixed various nullable fields not being nullable, and vice versa

### Removed
- Master/child accounts endpoints

## [3.0.1] - 2023-01-16
### Added
- Add document.collection.extractor.identifier to DocumentMeta
- Add an option to force display the index dropdown

### Changed
- Updated endpoints for old v2 and newer v3 to point to the correct places.

## [3.0.0] - 2023-01-13
### Added
- Added endpoints: Organization, Membership, Invitation, tags
- Added name, organization to DataPoint, change id to identifier
- Add new objects schemas Organization, OrganizationMembership, Invitation

### Changed
- Identifier instead of id as URL param
- Update data point filters
- Allow unlimited nesting in field config
- Change document state from "export" to "archive"

### Fixed
- Collection identifier should be nullable
- Don't paginate extractors endpoint
- Fix avatar uploads
- Allow writing resthookSignatureKey

## [2.8.0] - 2023-01-12
* Yanked as this was a breaking release, see newer release for more info

## [2.7.0] - 2023-01-10
### Added
- Add rectangles to Annotation, add position to referee, add actions to JobDescriptionSearchConfig

## [2.6.0] - 2023-01-09
### Fixed
- Bump version to force new release

## [2.5.0] - 2022-12-11
### Changed
- Allowing a few more fields in ResumeData to be null

## [2.4.0] - 2022-11-21
### Fixed
- Document meta pages without images should be nullable
- Small fixes for accreditiation and education return objects
- Various nullable fields in the API spec

### Security
- Bumped package versions for patch reasons

### Added
- Add reject_duplicates to document upload endpoint
- XML 404 response schema
- CustomData to resume search spec
- suggest skills and job titles endpoints

### Changed
- Update spec to allow XML content-type return from resumes, make totalYearsExperience nullable
- Allow additonalproperties for custom data upload (resumes) and search

### Removed
- Removed XML response types when there is an existing JSON response type, multiple response types are currently unsupported

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
