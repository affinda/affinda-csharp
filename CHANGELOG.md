# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [5.18.0] - 2024-01-31
### Added
- Add sourceEmailAddress to DocumentMeta model
- Add sourceEmailAddress to document meta
- Add list mapping data sources endpoint
- Add tablesBeta to InvoiceData model
- Added "website" data point type
- Add mapping and dataSource to the field endpoints

### Removed
- Removed "cell" data point type

### Changed
- Add URL annotation type

## [5.17.0] - 2023-12-04
### Fixed
- Fixed pkg dependencies

### Added
- Added AnnotationContentType
- Added show_custom_field_creation to Organization
- Add data mapping
- Add dropNullEnums to Field

## [5.16.0] - 2023-11-14
### Added
- Add PATCH /index/<name> endpoint
- Add user to Index object
- Add "compact" query parameter to GET /documents/<identifier> endpoint
- Add "compact" query parameter to POST /documents endpoint

## [5.15.0] - 2023-11-08
### Added
- Add `parent` field to `Annotation`

### Fixed
- Make `Annotation.rectangles` field non-nullable
- Make `Annotation.document` field required

### Changed
- Remove enum constraint from `ordering` on the `getAllDocuments` operation

## [5.14.0] - 2023-10-24
### Added
- Add display_enum_value config to Collection field config

### Changed
- Migrate display_enum_value from DataPoint to Collection field config

### Removed
- Remove display_enum_value from DataPoint

## [5.13.0] - 2023-10-19
### Added
- Add disableEditDocumentMetadata option to validation tool config
- Add field custom_identifier to DocumentMeta model
- Allow specifying custom_identifier when create/update document

### Deprecated
- Deprecate writing to identifier when creating/updating document

## [5.12.0] - 2023-10-03
### Added
- Add SOC group codes to classification

## [5.11.0] - 2023-09-21
### Added
- Allow creating workspace-scope webhook
- Add "document.rejected" webhook event

## [5.10.0] - 2023-07-26
### Changed
- Set CustomFieldConfig default to 0.5
- Make Field.slug nullable and not required

### Deprecated
- Deprecate Field.slug
- Deprecate `fields` in favor of `enabledChildFields` and `disabledChildFields` in Collection.fieldsLayout

### Added
- Allow create and enable/disable child fields in Collection.fieldsLayout

## [5.9.1] - 2023-06-28
### Added
- Allow create/update data point's `parent` and `displayEnumValue` property
- Add xml response to api spec to GET /v3/documenets to match existing functionality

### Changed
- Make `slug` and `organization` required when creating data point

### Removed
- Remove data point's `similarTo` property

## [5.9.0] - 2023-06-16
### Added
- Add `tailoredExtractorRequested` to Collection
- Add endpoint for update resumes and JD data

## [5.8.1] - 2023-06-14
### Added
- Add `rawText` to invoice data

## [5.8.0] - 2023-06-09
### Added
- Ability to post/patch languages for resumes in v2
- Add `include_public` parameter to /data_points endpoint
- Add `base_extractor` parameter to collection creation endpoint

### Changed
- Make `extractor` a non required field (internal use)

## [5.7.0] - 2023-06-07
### Changed
- Allow custom resume fields to be nullable
- Allow custom job description fields to be nullable
- Make "pdf" property in SearchResults nullable
- Nest line item table rows correctly.
- Nest line item table rows correctly.

### Removed
- Remove `include_child` filter from `/data_points` endpoint

### Added
- Custom fields to Job Descriptions
- Add custom data to job description search results
- Add international_country_code to phone number details
- Endpoints for add/remove tag for documents
- Identifier field in DocumentUpdate model
- Allow setting `region_bias` when uploading document
- rawText field to JobDescription Model
- Required fields for resthook subscriptions
- Add `fieldsLayout` to `Collection` schema

### Fixed
- Update python_requires to be PEP compliant

### Deprecated
- Deprecate `Collection.fields` in favor of `Collection.fieldsLayout`

## [5.6.0] - 2023-04-27
### Added
- Phone number details to Resume Candidate info
- Add some filters to `GET /documents` endpoint: `failed`, `ready`, `validatable`

### Changed
- Provide additional filters for data point choices, and allow data point choices to be specified for any existing text field.

### Fixed
- Fixed handling of rejectDuplicates in response objects causing parsing errors

## [5.5.1] - 2023-04-20
### Fixed
- Allow rejectDuplicates to be null

## [5.5.0] - 2023-04-18
### Added
- Add AsInvoice(), AsResume() and AsJobDesription() methods to Document

### Fixed
- Document.Data is now present in return objects

## [5.4.0] - 2023-04-17
### Added
- Add `whitelistIngestAddresses` to Workspace

### Fixed
- Make search config action fields required

### Changed
- rawText is now not nullable
- OccupationGroupSearchResult.children is now optional

## [5.3.0] - 2023-03-28
### Changed
- Updated README with api v3 example

### Added
- Adding group annotation content type
- Add rejectDuplicates setting to workspace
- Add `hideToolbar` to resume & JD search config
- Add ExtractorConfig object to Collection

## [5.2.0] - 2023-03-20
### Fixed
- fixed - Use OccupationGroupResult for v3 SearchAndMatch detail
- Fixed return type for InvoiceData.currencyCode

### Changed
- Don't require Field.slug

### Added
- Add redactedText field to ResumeData

## [5.1.0] - 2023-03-15
### Fixed
- Fixed type and path of data_point and data_point_choices
- Fixed missing data field on base Document type
- Fixed search and match return types
- fixed document error return types
- Ensure list endpoints have 'results' and 'count' properties required

### Changed
- Minor re-ordering of API spec paths
- Change Document API tag from Document API - Upload Documents to Document API - Document

## [5.0.1] - 2023-03-10
### Fixed
- Fixed resume search response object

## [5.0.0] - 2023-03-09
### Added
- Add resthook subscription endpoints
- Add link to affinda help docs for resthook creation

### Changed
- Remove extractor's `id` field, use `identifier` field instead

### Removed
- Remove extractor's `id` field
- Removed v2 endpoints

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
