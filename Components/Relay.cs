





<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
  <link rel="dns-prefetch" href="https://assets-cdn.github.com">
  <link rel="dns-prefetch" href="https://avatars0.githubusercontent.com">
  <link rel="dns-prefetch" href="https://avatars1.githubusercontent.com">
  <link rel="dns-prefetch" href="https://avatars2.githubusercontent.com">
  <link rel="dns-prefetch" href="https://avatars3.githubusercontent.com">
  <link rel="dns-prefetch" href="https://github-cloud.s3.amazonaws.com">
  <link rel="dns-prefetch" href="https://user-images.githubusercontent.com/">



  <link crossorigin="anonymous" media="all" integrity="sha512-1FLfhli3wF1EqKy4+DmsB7My96mQ71ZtDpkmg/2A8RP+5uDgJ0zAT8sRDwSG0p75xQjd9aMIVb58gpjhC//ngA==" rel="stylesheet" href="https://assets-cdn.github.com/assets/frameworks-dcca19dafecb17dea634d2f083dc7f9f.css" />
  <link crossorigin="anonymous" media="all" integrity="sha512-uGJbFWxK4WspQo+oFCI2hAyiVuYKTd6Ep9fkZ1fhY+MGMy7+Ay+mlWsYrmrZztkaKIQeiYHu+c5TJrrj64BTAA==" rel="stylesheet" href="https://assets-cdn.github.com/assets/github-e798667cb732fe9922518ac8647a0b53.css" />
  
  
  <link crossorigin="anonymous" media="all" integrity="sha512-8iMSuCJuXlxx1w/DvsPg6+lz0Yyo0B9Vrab6VEbpJqJNfzy1A66hyoc6sd7q+7QneSRUysd2yH4EyeZGJ8T7Dw==" rel="stylesheet" href="https://assets-cdn.github.com/assets/site-b541c19496dcf9b429be8b4e98f435e7.css" />
  

  <meta name="viewport" content="width=device-width">
  
  <title>IotCamera/Relay.cs at master · robertsundstrom/IotCamera · GitHub</title>
    <meta name="description" content="Camera app for .NET Core on Raspbian. Contribute to robertsundstrom/IotCamera development by creating an account on GitHub.">
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
  <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
  <meta property="fb:app_id" content="1401488693436528">

    
    <meta property="og:image" content="https://avatars3.githubusercontent.com/u/919580?s=400&amp;v=4" /><meta property="og:site_name" content="GitHub" /><meta property="og:type" content="object" /><meta property="og:title" content="robertsundstrom/IotCamera" /><meta property="og:url" content="https://github.com/robertsundstrom/IotCamera" /><meta property="og:description" content="Camera app for .NET Core on Raspbian. Contribute to robertsundstrom/IotCamera development by creating an account on GitHub." />

  <link rel="assets" href="https://assets-cdn.github.com/">
  
  <meta name="pjax-timeout" content="1000">
  
  <meta name="request-id" content="CD9C:6F9E:107B511:1C06E4F:5BA3CF03" data-pjax-transient>


  

  <meta name="selected-link" value="repo_source" data-pjax-transient>

      <meta name="google-site-verification" content="KT5gs8h0wvaagLKAVWq8bbeNwnZZK1r1XQysX3xurLU">
    <meta name="google-site-verification" content="ZzhVyEFwb7w3e0-uOTltm8Jsck2F5StVihD0exw2fsA">
    <meta name="google-site-verification" content="GXs5KoUUkNCoaAZn7wPN-t01Pywp9M3sEjnt_3_ZWPc">

  <meta name="octolytics-host" content="collector.githubapp.com" /><meta name="octolytics-app-id" content="github" /><meta name="octolytics-event-url" content="https://collector.githubapp.com/github-external/browser_event" /><meta name="octolytics-dimension-request_id" content="CD9C:6F9E:107B511:1C06E4F:5BA3CF03" /><meta name="octolytics-dimension-region_edge" content="iad" /><meta name="octolytics-dimension-region_render" content="iad" />
<meta name="analytics-location" content="/&lt;user-name&gt;/&lt;repo-name&gt;/blob/show" data-pjax-transient="true" />



    <meta name="google-analytics" content="UA-3769691-2">


<meta class="js-ga-set" name="dimension1" content="Logged Out">



  

      <meta name="hostname" content="github.com">
    <meta name="user-login" content="">

      <meta name="expected-hostname" content="github.com">
    <meta name="js-proxy-site-detection-payload" content="Y2Y4NThmNzhlMzRjYTE4YTBhZjc4MzEyNzQ0MjAxOWViZjlhMGMwMTcxYmE1YWRlMmVhMTAzODgwYjg4NWQxNnx7InJlbW90ZV9hZGRyZXNzIjoiODUuMTEuMTg5LjExOCIsInJlcXVlc3RfaWQiOiJDRDlDOjZGOUU6MTA3QjUxMToxQzA2RTRGOjVCQTNDRjAzIiwidGltZXN0YW1wIjoxNTM3NDYyMDI0LCJob3N0IjoiZ2l0aHViLmNvbSJ9">

    <meta name="enabled-features" content="DASHBOARD_V2_LAYOUT_OPT_IN,EXPLORE_DISCOVER_REPOSITORIES,UNIVERSE_BANNER,MARKETPLACE_PLAN_RESTRICTION_EDITOR,QUOTE_MARKDOWN">

  <meta name="html-safe-nonce" content="3d9e83ba1514355bd07266b600e35feacdbb005e">

  <meta http-equiv="x-pjax-version" content="948b02d7b6a9b2e25a2cbc95a1768210">
  

      <link href="https://github.com/robertsundstrom/IotCamera/commits/master.atom" rel="alternate" title="Recent Commits to IotCamera:master" type="application/atom+xml">

  <meta name="go-import" content="github.com/robertsundstrom/IotCamera git https://github.com/robertsundstrom/IotCamera.git">

  <meta name="octolytics-dimension-user_id" content="919580" /><meta name="octolytics-dimension-user_login" content="robertsundstrom" /><meta name="octolytics-dimension-repository_id" content="107713638" /><meta name="octolytics-dimension-repository_nwo" content="robertsundstrom/IotCamera" /><meta name="octolytics-dimension-repository_public" content="true" /><meta name="octolytics-dimension-repository_is_fork" content="false" /><meta name="octolytics-dimension-repository_network_root_id" content="107713638" /><meta name="octolytics-dimension-repository_network_root_nwo" content="robertsundstrom/IotCamera" /><meta name="octolytics-dimension-repository_explore_github_marketplace_ci_cta_shown" content="false" />


    <link rel="canonical" href="https://github.com/robertsundstrom/IotCamera/blob/master/src/Components/Relay.cs" data-pjax-transient>


  <meta name="browser-stats-url" content="https://api.github.com/_private/browser/stats">

  <meta name="browser-errors-url" content="https://api.github.com/_private/browser/errors">

  <link rel="mask-icon" href="https://assets-cdn.github.com/pinned-octocat.svg" color="#000000">
  <link rel="icon" type="image/x-icon" class="js-site-favicon" href="https://assets-cdn.github.com/favicon.ico">

<meta name="theme-color" content="#1e2327">


  <meta name="u2f-support" content="true">

  <link rel="manifest" href="/manifest.json" crossOrigin="use-credentials">

  </head>

  <body class="logged-out env-production page-blob">
    

  <div class="position-relative js-header-wrapper ">
    <a href="#start-of-content" tabindex="1" class="px-2 py-4 bg-blue text-white show-on-focus js-skip-to-content">Skip to content</a>
    <div id="js-pjax-loader-bar" class="pjax-loader-bar"><div class="progress"></div></div>

    
    
    



        

  <header class="Header header-logged-out  position-relative f4 py-3" role="banner" data-ga-load="(Logged out) Header, view, experiment:site_header_dropdowns; group:dropdowns">
    <div class="container-lg d-flex px-3">
      <div class="d-flex flex-justify-between flex-items-center">
          <a class="mr-5" href="https://github.com/" aria-label="Homepage" data-ga-click="(Logged out) Header, go to homepage, icon:logo-wordmark; experiment:site_header_dropdowns; group:dropdowns">
            <svg height="32" class="octicon octicon-mark-github text-white" viewBox="0 0 16 16" version="1.1" width="32" aria-hidden="true"><path fill-rule="evenodd" d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0 0 16 8c0-4.42-3.58-8-8-8z"/></svg>
          </a>
      </div>

      <div class="HeaderMenu HeaderMenu--experiment d-flex flex-justify-between flex-items-center flex-auto">
        <div class="d-none">
          <button class="btn-link js-details-target" type="button" aria-label="Toggle navigation" aria-expanded="false">
            <svg height="24" class="octicon octicon-x text-gray" viewBox="0 0 12 16" version="1.1" width="18" aria-hidden="true"><path fill-rule="evenodd" d="M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48L7.48 8z"/></svg>
          </button>
        </div>

          <nav class="">
            <ul class="d-flex list-style-none">
                <li class="HeaderMenu-item dropdown mr-5">
                  <details class="details-expanded details-reset js-dropdown-details ">
                    <summary class="HeaderMenu-target text-white">
                      <div class="d-flex flex-items-baseline flex-justify-between">
                        <span class="d-inline-block mr-1">Features</span>
                        <span class="dropdown-caret"></span>
                      </div>
                    </summary>
                    <div class="dropdown-menu dropdown-menu-s p-4 ml-n4 mt-3 mt-lg-2">
                      <a href="/features" class="d-block d-lg-flex flex-items-center flex-justify-between f5 link-gray-dark text-bold mb-2" data-ga-click="(Logged out) Header, go to Features, experiment:site_header_dropdowns; group:dropdowns"><span>Features overview</span> <svg height="16" class="octicon octicon-chevron-right text-gray-dark" viewBox="0 0 8 16" version="1.1" width="8" aria-hidden="true"><path fill-rule="evenodd" d="M7.5 8l-5 5L1 11.5 4.75 8 1 4.5 2.5 3l5 5z"/></svg></a>
                      <hr class="border border-dashed my-3 d-none d-lg-block">
                      <ul class="list-style-none f5">
                        <li class="mb-2"><a href="/features/code-review/" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Code review, experiment:site_header_dropdowns; group:dropdowns">Code review</a></li>
                        <li class="mb-2"><a href="/features/project-management/" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Project management, experiment:site_header_dropdowns; group:dropdowns">Project management</a></li>
                        <li class="mb-2"><a href="/features/integrations" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Integrations, experiment:site_header_dropdowns; group:dropdowns">Integrations</a></li>
                        <li class="mb-2"><a href="/features#team-management" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Team management, experiment:site_header_dropdowns; group:dropdowns">Team management</a></li>
                        <li class="mb-2"><a href="/features#social-coding" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Social coding, experiment:site_header_dropdowns; group:dropdowns">Social coding</a></li>
                        <li class="mb-2"><a href="/features#documentation" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Documentation, experiment:site_header_dropdowns; group:dropdowns">Documentation</a></li>
                        <li class="mb-2"><a href="/features#code-hosting" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Code hosting, experiment:site_header_dropdowns; group:dropdowns">Code hosting</a></li>
                      </ul>
                    </div>
                  </details>
                </li>
                <li class="HeaderMenu-item dropdown platform-nav mr-5">
                  <details class="details-expanded details-reset js-dropdown-details ">
                    <summary class="HeaderMenu-target text-white">
                      <div class="d-flex flex-items-baseline flex-justify-between">
                        <span class="d-inline-block mr-1">Platform</span>
                        <span class="dropdown-caret"></span>
                      </div>
                    </summary>
                    <div class="dropdown-menu dropdown-menu-s p-4 ml-n4 mt-3 mt-lg-2">
                      <div class="d-flex gutter-spacious ">
                        <div class="position-relative col-8">
                          <dl class="my-0">
                            <a href="/marketplace" class="d-flex mb-3 link-gray-dark no-underline" data-ga-click="(Logged out) Header, go to Marketplace, experiment:site_header_dropdowns; group:dropdowns">
                              <div class="mr-3">
                                <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 70.92 56.98" class="d-block" width="34"><title>Asset 1</title><g data-name="Layer 2"><path d="M6.18 57H1a1 1 0 0 1 0-2h5.18a1 1 0 0 1 0 2zM69.92 57h-5.18a1 1 0 1 1 0-2h5.18a1 1 0 0 1 0 2z" fill="#2088ff"></path><path d="M29.67 56.47a1 1 0 0 1-1-1V34.84H16v20.23a1 1 0 0 1-2 0V33.84a1 1 0 0 1 1-1h14.67a1 1 0 0 1 1 1v21.63a1 1 0 0 1-1 1z" fill="#79b8ff"></path><path d="M64.74 57H6.18a1 1 0 0 1-1-1v-8.65a1 1 0 0 1 2 0V55h56.56V33.84a1 1 0 0 1 2 0V56a1 1 0 0 1-1 1zM6.18 41.24a1 1 0 0 1-1-1V1a1 1 0 0 1 1-1h58.58a1 1 0 0 1 1 1v10.52a1 1 0 1 1-2 0V2H7.18v38.24a1 1 0 0 1-1 1z" fill="#2088ff"></path><path d="M56.82 45.94H36.34a1 1 0 0 1-1-1v-11.1a1 1 0 0 1 1-1h20.48a1 1 0 0 1 1 1v11.1a1 1 0 0 1-1 1zm-19.48-2h18.48v-9.1H37.34z" fill="#79b8ff"></path><path d="M31.55 27.5a7.84 7.84 0 0 1-5.21-2.42c-1.06-1-11.87-9.74-12-9.83a1 1 0 0 1 .66-1.78h43.66a1 1 0 0 1 .64.24l11.26 9.48a1 1 0 0 1-1.29 1.53l-11-9.25H17.81c3.26 2.65 9.08 7.4 9.88 8.12a6 6 0 0 0 3.87 1.9 3.3 3.3 0 0 0 3-1.95 1 1 0 1 1 1.82.82 5.3 5.3 0 0 1-4.83 3.14z" fill="#2088ff"></path><path d="M40.24 27.5a5.26 5.26 0 0 1-1.86-.34 1 1 0 0 1 .71-1.87 3.26 3.26 0 0 0 1.16.21 3.3 3.3 0 0 0 3-1.95 1 1 0 1 1 1.82.82 5.3 5.3 0 0 1-4.83 3.13zM48.82 27.5a5.26 5.26 0 0 1-1.82-.34 1 1 0 0 1 .71-1.87 3.26 3.26 0 0 0 1.16.21 3.3 3.3 0 0 0 3-1.95 1 1 0 1 1 1.82.82 5.3 5.3 0 0 1-4.87 3.13zM57.41 27.5a5.26 5.26 0 0 1-1.86-.34 1 1 0 0 1 .71-1.87 3.26 3.26 0 0 0 1.16.21 3.3 3.3 0 0 0 3-1.95 1 1 0 1 1 1.82.82 5.3 5.3 0 0 1-4.83 3.13zM66 27.5a5.26 5.26 0 0 1-1.86-.34 1 1 0 0 1 .71-1.87 3.26 3.26 0 0 0 1.15.21 3.3 3.3 0 0 0 3-2 1 1 0 0 1 1.82.82A5.31 5.31 0 0 1 66 27.5zM15 27.22a1 1 0 0 1-1-1V14.71a1 1 0 0 1 2 0v11.51a1 1 0 0 1-1 1z" fill="#2088ff"></path><path d="M44.16 25a1 1 0 0 1-.65-.24L38.07 20a1 1 0 0 1 1.3-1.52l5.43 4.67a1 1 0 0 1-.64 1.85zM35.52 25a1 1 0 0 1-.65-.24L29.44 20a1 1 0 0 1 1.3-1.52l5.43 4.67a1 1 0 0 1-.65 1.85zM52.74 25a1 1 0 0 1-.65-.24L46.66 20A1 1 0 0 1 48 18.53l5.43 4.67a1 1 0 0 1-.69 1.8zM61.33 25a1 1 0 0 1-.65-.24L55.25 20a1 1 0 0 1 1.3-1.52L62 23.2a1 1 0 0 1-.67 1.8zM22.23 8.42H6.51a1 1 0 0 1 0-2h15.72a1 1 0 0 1 0 2zM64.76 8.42H58.4a1 1 0 0 1 0-2h6.36a1 1 0 0 1 0 2z" fill="#2088ff"></path><path d="M46.58 45.72a1 1 0 0 1-1-1V34.1a1 1 0 0 1 2 0v10.62a1 1 0 0 1-1 1z" fill="#79b8ff"></path></g></svg>

                              </div>
                              <div>
                                <dt class="f4">Marketplace</dt>
                                <dd class="f6 text-gray">Find developer tools that work with GitHub</dd>
                              </div>
                            </a>
                            <a href="https://developer.github.com" class="d-flex mb-3 link-gray-dark no-underline" data-ga-click="(Logged out) Header, go to Developers, experiment:site_header_dropdowns; group:dropdowns">
                              <div class="mr-3">
                                <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 61.23 60.12" class="d-block" width="34"><title>Asset 1</title><g data-name="Layer 2"><path fill="none" stroke="#79b8ff" stroke-linecap="round" stroke-miterlimit="10" stroke-width="2" d="M14.75 13.22H3.52M18.02 6.33H6.54"></path><path fill="none" stroke="#2088ff" stroke-linecap="round" stroke-miterlimit="10" stroke-width="2" d="M56.96 51.89H45.73M60.23 44.99H48.75"></path><circle cx="22.5" cy="37.62" r="7.48" transform="rotate(-45 22.502 37.62)" fill="none" stroke="#2088ff" stroke-linecap="round" stroke-linejoin="round" stroke-width="2"></circle><path d="M36.72 29.79l1.35 3.4 5.93 2V40l-5.92 2.08-1.44 3.39 2.83 5.58L36 54.54l-5.66-2.7L27 53.22l-2 5.9h-4.89L18 53.18l-3.36-1.4L9 54.58 5.58 51.1l2.7-5.66-1.38-3.37-5.9-2v-4.89l5.92-2.08 1.44-3.39-2.82-5.57L9 20.69l5.66 2.7L18 22l2-5.9h4.89L27 22l3.36 1.4L36 20.66l3.45 3.48z" fill="none" stroke="#2088ff" stroke-linecap="round" stroke-linejoin="round" stroke-width="2"></path><path d="M7.22 22.48L9 20.69l5.66 2.7L18 22l2-5.9h4.89L27 22l3.36 1.4L36 20.66l3.45 3.48-2.7 5.66 1.35 3.4 5.93 2L44 40l-5.92 2.08-1.44 3.39 2.83 5.58-1.83 1.82" fill="none" stroke="#2088ff" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" opacity=".1"></path><path d="M37.22 14.11a6.05 6.05 0 1 1 8.56 8.56M30.07 12l-2.29-4.51 2.81-2.79 4.58 2.19 2.72-1.12L39.5 1h4l1.64 4.8 2.71 1.14 4.54-2.26 2.79 2.81L53 12.06l1.09 2.75 4.8 1.58v4L54.09 22l-1.16 2.74 2.29 4.51-2.82 2.83-4.58-2.19" fill="none" stroke="#79b8ff" stroke-linecap="round" stroke-linejoin="round" stroke-width="2"></path><path d="M29.14 6.14l1.45-1.44 4.58 2.19 2.72-1.12L39.5 1h4l1.64 4.8 2.71 1.14 4.54-2.26 2.79 2.81L53 12.06l1.09 2.75 4.8 1.58v4L54.09 22l-1.16 2.74 2.29 4.51-1.48 1.47" fill="none" stroke="#79b8ff" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" opacity=".1"></path></g></svg>

                              </div>
                              <div>
                                <dt class="f4">GitHub API</dt>
                                <dd class="f6 text-gray">Start building on the GitHub platform</dd>
                              </div>
                            </a>
                            <a href="https://partner.github.com/?source=github-header-loggedout&experiment=site_header_dropdowns&group=dropdowns" class="d-flex mb-3 link-gray-dark no-underline" data-ga-click="(Logged out) Header, go to Partner program, experiment:site_header_dropdowns; group:dropdowns">
                              <div class="mr-3">
                                <!-- Generator: Adobe Illustrator 22.1.0, SVG Export Plug-In . SVG Version: 6.00 Build 0)  --><svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" id="Layer_1" x="0px" y="0px" viewBox="0 0 37 23" style="enable-background:new 0 0 37 23;" xml:space="preserve" class="d-block" width="34">
<style type="text/css">
	.st0{fill:none;stroke:#79B8FF;stroke-linecap:round;stroke-linejoin:round;}
	.st1{fill:none;stroke:#2088FF;stroke-linecap:round;stroke-linejoin:round;}
</style>
<path class="st0" d="M6,1l4.5,1.4L5.3,15.2L1,12.9L6,1z"></path>
<path class="st1" d="M30.9,1.2L36,12.8l-3.9,2.6l-5.2-13L30.9,1.2z"></path>
<path class="st1" d="M5.2,11.7c0-0.6-0.5-1-1-1c-0.6,0-1,0.5-1,1c0,0.6,0.5,1,1,1"></path>
<path class="st0" d="M29.7,4.6c0.4,0,0.8-0.3,0.8-0.8v0c0-0.4-0.3-0.8-0.8-0.8h0c-0.4,0-0.8,0.3-0.8,0.8v0C29,4.3,29.3,4.6,29.7,4.6  L29.7,4.6z"></path>
<path class="st0" d="M6.2,13.4c0,0,2.4,0.8,3.9,2.3L6.2,13.4z M9.6,4.8c0,0,4.3,2.3,6.9,2.8L9.6,4.8z"></path>
<path class="st1" d="M30.4,11.5l-3.2,2.6"></path>
<path class="st0" d="M19.7,9l8.7,6.2c0.4,0.3,1.1,1.2,0.4,2.2c-0.7,0.9-1.5,0.2-1.5,0.2l-6-4.2"></path>
<path class="st1" d="M27.5,4.8c0,0-2,1.6-3.3,1.4c-1.3-0.2-4.7-0.9-4.7-0.9c-0.7,0.8-3.7,3.5-4.6,3.6c0,0-0.2,1.5,1.6,1.3  c1.7-0.2,2.7-0.9,3.7-1.7"></path>
<path class="st0" d="M24.6,18.9c0,0,0.2,0.9-0.2,1.4c-0.2,0.3-0.7,0.6-1.3,0.3l-3.7-2.5L24.6,18.9z M27.1,17.6c0,0,0.1,0.9-0.5,1.4  c-0.3,0.3-0.8,0.6-1.5,0.3l-5.9-4.3L27.1,17.6z"></path>
<path class="st0" d="M22.4,20.1c0,0,0,0.6-0.2,1.1c-0.2,0.3-0.4,0.6-1.1,0.4l-2.8-1.9"></path>
<path class="st1" d="M17.8,17c0.3-0.3,1.6-0.2,1.4,1c-0.3,1.2-1.7,2.4-2.1,2.6c-0.4,0.2-1.4,0.2-1.4-0.7L17.8,17z M14.3,14.6  c0,0-0.7-1.5-1.5-1.2c-0.8,0.3-2.8,2-2.8,2.7c0,0.7,1,1.5,1.9,0.8L14.3,14.6z"></path>
<path class="st1" d="M16.1,15.8c0.2-0.3,1.8-0.4,1.5,1.1c-0.3,1.4-2.1,2.7-2.4,2.9c-0.3,0.1-1.7,0.3-1.9-0.9"></path>
<path class="st1" d="M15.9,16.1c0,0,0.5-0.9-0.1-1.5c-0.6-0.6-1.2-0.2-1.6,0.2c-0.3,0.3-2.9,2.8-2.9,2.8s0.5,1.8,1.7,1.3  C14.2,18.5,15.9,16.1,15.9,16.1z"></path>
</svg>

                              </div>
                              <div>
                                <dt class="f4">Partner program</dt>
                                <dd class="f6 text-gray">Help millions of developers do their best work</dd>
                              </div>
                            </a>
                          </dl>
                          <div class="d-none d-lg-block border-left position-absolute top-0 right-0 bottom-0"></div>
                        </div>
                        <div class="col-4">
                          <strong class="d-block f5 text-bold mb-2 text-gray-dark">Apps by GitHub</strong>
                          <ul class="list-style-none f5">
                            <li class="mb-2"><a href="https://desktop.github.com/" class="link-gray" data-ga-click="(Logged out) Header, go to Desktop, experiment:site_header_dropdowns; group:dropdowns">Desktop <span style="color: #959da5;">&#8599;</span></a></li>
                            <li class="mb-2"><a href="https://atom.io/" class="link-gray" data-ga-click="(Logged out) Header, go to Atom, experiment:site_header_dropdowns; group:dropdowns">Atom <span style="color: #959da5;">&#8599;</span></a></li>
                            <li class="mb-2"><a href="https://visualstudio.github.com/" class="link-gray" data-ga-click="(Logged out) Header, go to Visual Studio, experiment:site_header_dropdowns; group:dropdowns">Visual Studio <span style="color: #959da5;">&#8599;</span></a></li>
                            <li class="mb-2"><a href="https://unity.github.com/" class="link-gray" data-ga-click="(Logged out) Header, go to Unity Extension, experiment:site_header_dropdowns; group:dropdowns">Unity Extension <span style="color: #959da5;">&#8599;</span></a></li>
                          </ul>
                        </div>
                      </div>
                    </div>
                  </details>
                </li>
                <li class="HeaderMenu-item dropdown mr-5">
                  <details class="details-expanded details-reset js-dropdown-details ">
                    <summary class="HeaderMenu-target text-white">
                      <div class="d-flex flex-items-baseline flex-justify-between">
                        <span class="d-inline-block mr-1">Business</span>
                        <span class="dropdown-caret"></span>
                      </div>
                    </summary>
                    <div class="dropdown-menu dropdown-menu-s p-4 ml-n4 mt-3 mt-lg-2">
                      <a href="/business" class="d-block d-lg-flex flex-items-center flex-justify-between f5 link-gray-dark text-bold mb-2" data-ga-click="(Logged out) Header, go to Business, experiment:site_header_dropdowns; group:dropdowns"><span>Business overview</span> <svg height="16" class="octicon octicon-chevron-right text-gray-dark" viewBox="0 0 8 16" version="1.1" width="8" aria-hidden="true"><path fill-rule="evenodd" d="M7.5 8l-5 5L1 11.5 4.75 8 1 4.5 2.5 3l5 5z"/></svg></a>
                      <hr class="border border-dashed my-3 d-none d-lg-block">
                      <ul class="list-style-none f5">
                        <li class="mb-2"><a href="/business/customers" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Customers, experiment:site_header_dropdowns; group:dropdowns">Customers</a></li>
                        <li class="mb-2"><a href="/business/security" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Security, experiment:site_header_dropdowns; group:dropdowns">Security</a></li>
                        <li class="mb-2"><a href="https://enterprise.github.com/contact" class="d-block link-gray" data-ga-click="(Logged out) Header, go to Contact, experiment:site_header_dropdowns; group:dropdowns">Contact</a></li>
                      </ul>
                    </div>
                  </details>
                </li>

                <li class="HeaderMenu-item dropdown mr-5">
                  <details class="details-expanded details-reset js-dropdown-details ">
                    <summary class="HeaderMenu-target text-white">
                      <div class="d-flex flex-items-baseline flex-justify-between">
                        <span class="d-inline-block mr-1">Explore</span>
                        <span class="dropdown-caret"></span>
                      </div>
                    </summary>
                    <div class="dropdown-menu dropdown-menu-s p-4 ml-n4 mt-3 mt-lg-2">
                      <ul class="list-style-none f5">
                        <li class="mb-2"><a href="/explore" class="d-lg-flex flex-items-center flex-justify-between link-gray-dark text-bold" data-ga-click="(Logged out) Header, go to Explore GitHub, experiment:site_header_dropdowns; group:dropdowns"><span>Explore GitHub</span> <svg height="16" class="octicon octicon-chevron-right text-gray-dark" viewBox="0 0 8 16" version="1.1" width="8" aria-hidden="true"><path fill-rule="evenodd" d="M7.5 8l-5 5L1 11.5 4.75 8 1 4.5 2.5 3l5 5z"/></svg></a></li>
                        <li class="mb-3"><a href="/trending" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Trending, experiment:site_header_dropdowns; group:dropdowns">Trending</a></li>
                      </ul>

                      <hr class="border border-dashed my-3 d-none d-lg-block">

                      <strong class="d-block f5 text-bold mb-2 text-gray-dark">Learn</strong>
                      <ul class="list-style-none f5">
                        <li class="mb-2"><a href="/topics" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Topics, experiment:site_header_dropdowns; group:dropdowns">Topics</a></li>
                        <li class="mb-2"><a href="/collections" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Collections, experiment:site_header_dropdowns; group:dropdowns">Collections</a></li>
                        <li class="mb-2"><a href="https://lab.github.com/" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Learning Lab, experiment:site_header_dropdowns; group:dropdowns">Learning Lab <span style="color: #959da5;">&#8599;</span></a></li>
                        <li class="mb-3"><a href="https://opensource.guide/" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Open source guides, experiment:site_header_dropdowns; group:dropdowns">Open source guides <span style="color: #959da5;">&#8599;</span></a></li>
                      </ul>

                      <hr class="border border-dashed my-3 d-none d-lg-block">

                      <strong class="d-block f5 text-bold mb-2 text-gray-dark">Connect</strong>
                      <ul class="list-style-none f5">
                        <li class="mb-2"><a href="/events" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Events, experiment:site_header_dropdowns; group:dropdowns">Events</a></li>
                        <li class="mb-2"><a href="https://github.community/" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Community forum, experiment:site_header_dropdowns; group:dropdowns">Community forum <span style="color: #959da5;">&#8599;</span></a></li>
                        <li class="mb-3"><a href="https://education.github.community/" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Education community, experiment:site_header_dropdowns; group:dropdowns">Education community <span style="color: #959da5;">&#8599;</span></a></li>
                      </ul>
                    </div>
                  </details>
                </li>

                <li class="HeaderMenu-item dropdown mr-5">
                  <details class="details-expanded details-reset js-dropdown-details ">
                    <summary class="HeaderMenu-target text-white">
                      <div class="d-flex flex-items-baseline flex-justify-between">
                        <span class="d-inline-block mr-1">Pricing</span>
                        <span class="dropdown-caret"></span>
                      </div>
                    </summary>
                    <div class="dropdown-menu dropdown-menu-s p-4 ml-n4 mt-3 mt-lg-2">
                      <a href="/pricing" class="d-block d-lg-flex flex-items-center flex-justify-between f5 link-gray-dark text-bold mb-3" data-ga-click="(Logged out) Header, go to Pricing, experiment:site_header_dropdowns; group:dropdowns"><span>Pricing overview</span> <svg height="16" class="octicon octicon-chevron-right text-gray-dark" viewBox="0 0 8 16" version="1.1" width="8" aria-hidden="true"><path fill-rule="evenodd" d="M7.5 8l-5 5L1 11.5 4.75 8 1 4.5 2.5 3l5 5z"/></svg></a>
                      <hr class="border border-dashed my-3 d-none d-lg-block">
                      <strong class="d-block f5 text-bold text-gray-dark mb-2">Plans</strong>
                      <ul class="list-style-none f5">
                        <li class="mb-2"><a href="/pricing/developer" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Developer, experiment:site_header_dropdowns; group:dropdowns">Developer</a></li>
                        <li class="mb-2"><a href="/pricing/team" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Team, experiment:site_header_dropdowns; group:dropdowns">Team</a></li>
                        <li class="mb-2"><a href="/pricing/business-hosted" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Business, experiment:site_header_dropdowns; group:dropdowns">Business</a></li>
                        <li class="mb-3"><a href="/pricing#feature-comparison" class="link-gray d-block" data-ga-click="(Logged out) Header, go to Compare plans, experiment:site_header_dropdowns; group:dropdowns">Compare plans</a></li>
                      </ul>
                      <hr class="border border-dashed my-3 d-none d-lg-block">
                      <ul class="list-style-none f5">
                        <li class="mb-2"><a href="https://github.com/nonprofit" class="link-gray-dark" data-ga-click="(Logged out) Header, go to Nonprofits, experiment:site_header_dropdowns; group:dropdowns">Nonprofits</a></li>
                        <li class="mb-2"><a href="https://education.github.com/discount_requests/new" class="link-gray-dark" data-ga-click="(Logged out) Header, go to Education, experiment:site_header_dropdowns; group:dropdowns">Education <span style="color: #959da5;">&#8599;</span></a></li>
                      </ul>
                    </div>
                  </details>
                </li>
            </ul>
          </nav>

        <div class="d-flex flex-items-center">
            <div class="d-flex mr-3 flex-items-center">
              <div class="header-search scoped-search site-scoped-search js-site-search position-relative js-jump-to"
  role="combobox"
  aria-owns="jump-to-results"
  aria-label="Search or jump to"
  aria-haspopup="listbox"
  aria-expanded="false"
>
  <div class="position-relative">
    <!-- '"` --><!-- </textarea></xmp> --></option></form><form class="js-site-search-form" data-scope-type="Repository" data-scope-id="107713638" data-scoped-search-url="/robertsundstrom/IotCamera/search" data-unscoped-search-url="/search" action="/robertsundstrom/IotCamera/search" accept-charset="UTF-8" method="get"><input name="utf8" type="hidden" value="&#x2713;" />
      <label class="form-control header-search-wrapper header-search-wrapper-jump-to position-relative d-flex flex-justify-between flex-items-center js-chromeless-input-container">
        <input type="text"
          class="form-control header-search-input jump-to-field js-jump-to-field js-site-search-focus js-site-search-field is-clearable"
          data-hotkey="s,/"
          name="q"
          value=""
          placeholder="Search"
          data-unscoped-placeholder="Search GitHub"
          data-scoped-placeholder="Search"
          autocapitalize="off"
          aria-autocomplete="list"
          aria-controls="jump-to-results"
          data-jump-to-suggestions-path="/_graphql/GetSuggestedNavigationDestinations#csrf-token=qa4XxnEHCRs2+0Rpvr726XPrvIZRZm/CxEhIGIw9hXgiIBmMWpOSW8wFVfnyHECQV39gbmHoXYOBeVatvNroAg=="
          spellcheck="false"
          autocomplete="off"
          >
          <input type="hidden" class="js-site-search-type-field" name="type" >
            <img src="https://assets-cdn.github.com/images/search-shortcut-hint.svg" alt="" class="mr-2 header-search-key-slash">

            <div class="Box position-absolute overflow-hidden d-none jump-to-suggestions js-jump-to-suggestions-container">
              <ul class="d-none js-jump-to-suggestions-template-container">
                <li class="d-flex flex-justify-start flex-items-center p-0 f5 navigation-item js-navigation-item" role="option">
                  <a tabindex="-1" class="no-underline d-flex flex-auto flex-items-center p-2 jump-to-suggestions-path js-jump-to-suggestion-path js-navigation-open" href="">
                    <div class="jump-to-octicon js-jump-to-octicon mr-2 text-center d-none">
                      <svg height="16" width="16" class="octicon octicon-repo flex-shrink-0 js-jump-to-octicon-repo d-none" title="Repository" aria-label="Repository" viewBox="0 0 12 16" version="1.1" role="img"><path fill-rule="evenodd" d="M4 9H3V8h1v1zm0-3H3v1h1V6zm0-2H3v1h1V4zm0-2H3v1h1V2zm8-1v12c0 .55-.45 1-1 1H6v2l-1.5-1.5L3 16v-2H1c-.55 0-1-.45-1-1V1c0-.55.45-1 1-1h10c.55 0 1 .45 1 1zm-1 10H1v2h2v-1h3v1h5v-2zm0-10H2v9h9V1z"/></svg>
                      <svg height="16" width="16" class="octicon octicon-project flex-shrink-0 js-jump-to-octicon-project d-none" title="Project" aria-label="Project" viewBox="0 0 15 16" version="1.1" role="img"><path fill-rule="evenodd" d="M10 12h3V2h-3v10zm-4-2h3V2H6v8zm-4 4h3V2H2v12zm-1 1h13V1H1v14zM14 0H1a1 1 0 0 0-1 1v14a1 1 0 0 0 1 1h13a1 1 0 0 0 1-1V1a1 1 0 0 0-1-1z"/></svg>
                      <svg height="16" width="16" class="octicon octicon-search flex-shrink-0 js-jump-to-octicon-search d-none" title="Search" aria-label="Search" viewBox="0 0 16 16" version="1.1" role="img"><path fill-rule="evenodd" d="M15.7 13.3l-3.81-3.83A5.93 5.93 0 0 0 13 6c0-3.31-2.69-6-6-6S1 2.69 1 6s2.69 6 6 6c1.3 0 2.48-.41 3.47-1.11l3.83 3.81c.19.2.45.3.7.3.25 0 .52-.09.7-.3a.996.996 0 0 0 0-1.41v.01zM7 10.7c-2.59 0-4.7-2.11-4.7-4.7 0-2.59 2.11-4.7 4.7-4.7 2.59 0 4.7 2.11 4.7 4.7 0 2.59-2.11 4.7-4.7 4.7z"/></svg>
                    </div>

                    <img class="avatar mr-2 flex-shrink-0 js-jump-to-suggestion-avatar d-none" alt="" aria-label="Team" src="" width="28" height="28">

                    <div class="jump-to-suggestion-name js-jump-to-suggestion-name flex-auto overflow-hidden text-left no-wrap css-truncate css-truncate-target">
                    </div>

                    <div class="border rounded-1 flex-shrink-0 bg-gray px-1 text-gray-light ml-1 f6 d-none js-jump-to-badge-search">
                      <span class="js-jump-to-badge-search-text-default d-none" aria-label="in this repository">
                        In this repository
                      </span>
                      <span class="js-jump-to-badge-search-text-global d-none" aria-label="in all of GitHub">
                        All GitHub
                      </span>
                      <span aria-hidden="true" class="d-inline-block ml-1 v-align-middle">↵</span>
                    </div>

                    <div aria-hidden="true" class="border rounded-1 flex-shrink-0 bg-gray px-1 text-gray-light ml-1 f6 d-none d-on-nav-focus js-jump-to-badge-jump">
                      Jump to
                      <span class="d-inline-block ml-1 v-align-middle">↵</span>
                    </div>
                  </a>
                </li>
              </ul>
              <ul class="d-none js-jump-to-no-results-template-container">
                <li class="d-flex flex-justify-center flex-items-center p-3 f5 d-none">
                  <span class="text-gray">No suggested jump to results</span>
                </li>
              </ul>

              <ul id="jump-to-results" role="listbox" class="js-navigation-container jump-to-suggestions-results-container js-jump-to-suggestions-results-container" >
                <li class="d-flex flex-justify-center flex-items-center p-0 f5">
                  <img src="https://assets-cdn.github.com/images/spinners/octocat-spinner-128.gif" alt="Octocat Spinner Icon" class="m-2" width="28">
                </li>
              </ul>
            </div>
      </label>
</form>  </div>
</div>

            </div>

          <a class="HeaderMenu-target text-white no-underline mr-3" href="/login?return_to=%2Frobertsundstrom%2FIotCamera%2Fblob%2Fmaster%2Fsrc%2FComponents%2FRelay.cs" data-ga-click="(Logged out) Header, clicked Sign in, text:sign-in; experiment:site_header_dropdowns; group:dropdowns">Sign&nbsp;in</a>
            <a class="HeaderMenu-target d-inline-block text-white no-underline border border-gray-dark rounded-2 px-2 py-1" href="/join" data-ga-click="(Logged out) Header, clicked Sign up, text:sign-up; experiment:site_header_dropdowns; group:dropdowns">Sign&nbsp;up</a>
        </div>
      </div>
    </div>
  </header>


  </div>

  <div id="start-of-content" class="show-on-focus"></div>

    <div id="js-flash-container">


</div>



  <div role="main" class="application-main ">
        <div itemscope itemtype="http://schema.org/SoftwareSourceCode" class="">
    <div id="js-repo-pjax-container" data-pjax-container >
      







  <div class="pagehead repohead instapaper_ignore readability-menu experiment-repo-nav  ">
    <div class="repohead-details-container clearfix container">

      <ul class="pagehead-actions">
  <li>
      <a href="/login?return_to=%2Frobertsundstrom%2FIotCamera"
    class="btn btn-sm btn-with-count tooltipped tooltipped-s"
    aria-label="You must be signed in to watch a repository" rel="nofollow">
    <svg class="octicon octicon-eye v-align-text-bottom" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M8.06 2C3 2 0 8 0 8s3 6 8.06 6C13 14 16 8 16 8s-3-6-7.94-6zM8 12c-2.2 0-4-1.78-4-4 0-2.2 1.8-4 4-4 2.22 0 4 1.8 4 4 0 2.22-1.78 4-4 4zm2-4c0 1.11-.89 2-2 2-1.11 0-2-.89-2-2 0-1.11.89-2 2-2 1.11 0 2 .89 2 2z"/></svg>
    Watch
  </a>
  <a class="social-count" href="/robertsundstrom/IotCamera/watchers"
     aria-label="1 user is watching this repository">
    1
  </a>

  </li>

  <li>
      <a href="/login?return_to=%2Frobertsundstrom%2FIotCamera"
    class="btn btn-sm btn-with-count tooltipped tooltipped-s"
    aria-label="You must be signed in to star a repository" rel="nofollow">
    <svg class="octicon octicon-star v-align-text-bottom" viewBox="0 0 14 16" version="1.1" width="14" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M14 6l-4.9-.64L7 1 4.9 5.36 0 6l3.6 3.26L2.67 14 7 11.67 11.33 14l-.93-4.74L14 6z"/></svg>
    Star
  </a>

    <a class="social-count js-social-count" href="/robertsundstrom/IotCamera/stargazers"
      aria-label="4 users starred this repository">
      4
    </a>

  </li>

  <li>
      <a href="/login?return_to=%2Frobertsundstrom%2FIotCamera"
        class="btn btn-sm btn-with-count tooltipped tooltipped-s"
        aria-label="You must be signed in to fork a repository" rel="nofollow">
        <svg class="octicon octicon-repo-forked v-align-text-bottom" viewBox="0 0 10 16" version="1.1" width="10" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M8 1a1.993 1.993 0 0 0-1 3.72V6L5 8 3 6V4.72A1.993 1.993 0 0 0 2 1a1.993 1.993 0 0 0-1 3.72V6.5l3 3v1.78A1.993 1.993 0 0 0 5 15a1.993 1.993 0 0 0 1-3.72V9.5l3-3V4.72A1.993 1.993 0 0 0 8 1zM2 4.2C1.34 4.2.8 3.65.8 3c0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2zm3 10c-.66 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2zm3-10c-.66 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2z"/></svg>
        Fork
      </a>

    <a href="/robertsundstrom/IotCamera/network/members" class="social-count"
       aria-label="2 users forked this repository">
      2
    </a>
  </li>
</ul>

      <h1 class="public ">
  <svg class="octicon octicon-repo" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9H3V8h1v1zm0-3H3v1h1V6zm0-2H3v1h1V4zm0-2H3v1h1V2zm8-1v12c0 .55-.45 1-1 1H6v2l-1.5-1.5L3 16v-2H1c-.55 0-1-.45-1-1V1c0-.55.45-1 1-1h10c.55 0 1 .45 1 1zm-1 10H1v2h2v-1h3v1h5v-2zm0-10H2v9h9V1z"/></svg>
  <span class="author" itemprop="author"><a class="url fn" rel="author" href="/robertsundstrom">robertsundstrom</a></span><!--
--><span class="path-divider">/</span><!--
--><strong itemprop="name"><a data-pjax="#js-repo-pjax-container" href="/robertsundstrom/IotCamera">IotCamera</a></strong>

</h1>

    </div>
    
<nav class="reponav js-repo-nav js-sidenav-container-pjax container"
     itemscope
     itemtype="http://schema.org/BreadcrumbList"
     role="navigation"
     data-pjax="#js-repo-pjax-container">

  <span itemscope itemtype="http://schema.org/ListItem" itemprop="itemListElement">
    <a class="js-selected-navigation-item selected reponav-item" itemprop="url" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches repo_packages /robertsundstrom/IotCamera" href="/robertsundstrom/IotCamera">
      <svg class="octicon octicon-code" viewBox="0 0 14 16" version="1.1" width="14" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M9.5 3L8 4.5 11.5 8 8 11.5 9.5 13 14 8 9.5 3zm-5 0L0 8l4.5 5L6 11.5 2.5 8 6 4.5 4.5 3z"/></svg>
      <span itemprop="name">Code</span>
      <meta itemprop="position" content="1">
</a>  </span>

    <span itemscope itemtype="http://schema.org/ListItem" itemprop="itemListElement">
      <a itemprop="url" data-hotkey="g i" class="js-selected-navigation-item reponav-item" data-selected-links="repo_issues repo_labels repo_milestones /robertsundstrom/IotCamera/issues" href="/robertsundstrom/IotCamera/issues">
        <svg class="octicon octicon-issue-opened" viewBox="0 0 14 16" version="1.1" width="14" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7 2.3c3.14 0 5.7 2.56 5.7 5.7s-2.56 5.7-5.7 5.7A5.71 5.71 0 0 1 1.3 8c0-3.14 2.56-5.7 5.7-5.7zM7 1C3.14 1 0 4.14 0 8s3.14 7 7 7 7-3.14 7-7-3.14-7-7-7zm1 3H6v5h2V4zm0 6H6v2h2v-2z"/></svg>
        <span itemprop="name">Issues</span>
        <span class="Counter">0</span>
        <meta itemprop="position" content="2">
</a>    </span>

  <span itemscope itemtype="http://schema.org/ListItem" itemprop="itemListElement">
    <a data-hotkey="g p" itemprop="url" class="js-selected-navigation-item reponav-item" data-selected-links="repo_pulls checks /robertsundstrom/IotCamera/pulls" href="/robertsundstrom/IotCamera/pulls">
      <svg class="octicon octicon-git-pull-request" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M11 11.28V5c-.03-.78-.34-1.47-.94-2.06C9.46 2.35 8.78 2.03 8 2H7V0L4 3l3 3V4h1c.27.02.48.11.69.31.21.2.3.42.31.69v6.28A1.993 1.993 0 0 0 10 15a1.993 1.993 0 0 0 1-3.72zm-1 2.92c-.66 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2zM4 3c0-1.11-.89-2-2-2a1.993 1.993 0 0 0-1 3.72v6.56A1.993 1.993 0 0 0 2 15a1.993 1.993 0 0 0 1-3.72V4.72c.59-.34 1-.98 1-1.72zm-.8 10c0 .66-.55 1.2-1.2 1.2-.65 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2zM2 4.2C1.34 4.2.8 3.65.8 3c0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2z"/></svg>
      <span itemprop="name">Pull requests</span>
      <span class="Counter">0</span>
      <meta itemprop="position" content="3">
</a>  </span>

    <a data-hotkey="g b" class="js-selected-navigation-item reponav-item" data-selected-links="repo_projects new_repo_project repo_project /robertsundstrom/IotCamera/projects" href="/robertsundstrom/IotCamera/projects">
      <svg class="octicon octicon-project" viewBox="0 0 15 16" version="1.1" width="15" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M10 12h3V2h-3v10zm-4-2h3V2H6v8zm-4 4h3V2H2v12zm-1 1h13V1H1v14zM14 0H1a1 1 0 0 0-1 1v14a1 1 0 0 0 1 1h13a1 1 0 0 0 1-1V1a1 1 0 0 0-1-1z"/></svg>
      Projects
      <span class="Counter" >0</span>
</a>



  <a class="js-selected-navigation-item reponav-item" data-selected-links="repo_graphs repo_contributors dependency_graph pulse /robertsundstrom/IotCamera/pulse" href="/robertsundstrom/IotCamera/pulse">
    <svg class="octicon octicon-graph" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M16 14v1H0V0h1v14h15zM5 13H3V8h2v5zm4 0H7V3h2v10zm4 0h-2V6h2v7z"/></svg>
    Insights
</a>

</nav>


  </div>

<div class="container new-discussion-timeline experiment-repo-nav  ">
  <div class="repository-content ">

    
  <a class="d-none js-permalink-shortcut" data-hotkey="y" href="/robertsundstrom/IotCamera/blob/3a81c5527791fc081a13b71955903aaeca75433e/src/Components/Relay.cs">Permalink</a>

  <!-- blob contrib key: blob_contributors:v21:5b0837ee6a8d39d1b7ca19cc6a605e11 -->

      <div class="signup-prompt-bg rounded-1">
      <div class="signup-prompt p-4 text-center mb-4 rounded-1">
        <div class="position-relative">
          <!-- '"` --><!-- </textarea></xmp> --></option></form><form action="/site/dismiss_signup_prompt" accept-charset="UTF-8" method="post"><input name="utf8" type="hidden" value="&#x2713;" /><input type="hidden" name="authenticity_token" value="b3jBBhOKjxluzMUr5ygPONpaqu+SRDZIBtb0BxaFFJmGkecH3cbrMhtk3pJ7uYgmyAL16invsMirxhyIfQdmIQ==" />
            <button type="submit" class="position-absolute top-0 right-0 btn-link link-gray" data-ga-click="(Logged out) Sign up prompt, clicked Dismiss, text:dismiss">
              Dismiss
            </button>
</form>          <h3 class="pt-2">Join GitHub today</h3>
          <p class="col-6 mx-auto">GitHub is home to over 28 million developers working together to host and review code, manage projects, and build software together.</p>
          <a class="btn btn-primary" href="/join?source=prompt-blob-show" data-ga-click="(Logged out) Sign up prompt, clicked Sign up, text:sign-up">Sign up</a>
        </div>
      </div>
    </div>


  <div class="file-navigation">
    
<div class="select-menu branch-select-menu js-menu-container js-select-menu float-left">
  <button class=" btn btn-sm select-menu-button js-menu-target css-truncate" data-hotkey="w"
    
    type="button" aria-label="Switch branches or tags" aria-expanded="false" aria-haspopup="true">
      <i>Branch:</i>
      <span class="js-select-button css-truncate-target">master</span>
  </button>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax>

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <svg class="octicon octicon-x js-menu-close" role="img" aria-label="Close" viewBox="0 0 12 16" version="1.1" width="12" height="16"><path fill-rule="evenodd" d="M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48L7.48 8z"/></svg>
        <span class="select-menu-title">Switch branches/tags</span>
      </div>

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="form-control js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" data-filter-placeholder="Filter branches/tags" class="js-select-menu-tab" role="tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" data-filter-placeholder="Find a tag…" class="js-select-menu-tab" role="tab">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches" role="menu">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <a class="select-menu-item js-navigation-item js-navigation-open "
               href="/robertsundstrom/IotCamera/blob/develop/src/Components/Relay.cs"
               data-name="develop"
               data-skip-pjax="true"
               rel="nofollow">
              <svg class="octicon octicon-check select-menu-item-icon" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5L12 5z"/></svg>
              <span class="select-menu-item-text css-truncate-target js-select-menu-filter-text">
                develop
              </span>
            </a>
            <a class="select-menu-item js-navigation-item js-navigation-open selected"
               href="/robertsundstrom/IotCamera/blob/master/src/Components/Relay.cs"
               data-name="master"
               data-skip-pjax="true"
               rel="nofollow">
              <svg class="octicon octicon-check select-menu-item-icon" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5L12 5z"/></svg>
              <span class="select-menu-item-text css-truncate-target js-select-menu-filter-text">
                master
              </span>
            </a>
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div>

    </div>
  </div>
</div>

    <div class="BtnGroup float-right">
      <a href="/robertsundstrom/IotCamera/find/master"
            class="js-pjax-capture-input btn btn-sm BtnGroup-item"
            data-pjax
            data-hotkey="t">
        Find file
      </a>
      <clipboard-copy for="blob-path" class="btn btn-sm BtnGroup-item">
        Copy path
      </clipboard-copy>
    </div>
    <div id="blob-path" class="breadcrumb">
      <span class="repo-root js-repo-root"><span class="js-path-segment"><a data-pjax="true" href="/robertsundstrom/IotCamera"><span>IotCamera</span></a></span></span><span class="separator">/</span><span class="js-path-segment"><a data-pjax="true" href="/robertsundstrom/IotCamera/tree/master/src"><span>src</span></a></span><span class="separator">/</span><span class="js-path-segment"><a data-pjax="true" href="/robertsundstrom/IotCamera/tree/master/src/Components"><span>Components</span></a></span><span class="separator">/</span><strong class="final-path">Relay.cs</strong>
    </div>
  </div>


  <include-fragment src="/robertsundstrom/IotCamera/contributors/master/src/Components/Relay.cs" class="commit-tease commit-loader">
    <div>
      Fetching contributors&hellip;
    </div>

    <div class="commit-tease-contributors">
        <img alt="" class="loader-loading float-left" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32-EAF2F5.gif" width="16" height="16" />
      <span class="loader-error">Cannot retrieve contributors at this time</span>
    </div>
</include-fragment>


  <div class="file">
    <div class="file-header">
  <div class="file-actions">

    <div class="BtnGroup">
      <a id="raw-url" class="btn btn-sm BtnGroup-item" href="/robertsundstrom/IotCamera/raw/master/src/Components/Relay.cs">Raw</a>
        <a class="btn btn-sm js-update-url-with-hash BtnGroup-item" data-hotkey="b" href="/robertsundstrom/IotCamera/blame/master/src/Components/Relay.cs">Blame</a>
      <a rel="nofollow" class="btn btn-sm BtnGroup-item" href="/robertsundstrom/IotCamera/commits/master/src/Components/Relay.cs">History</a>
    </div>

        <a class="btn-octicon tooltipped tooltipped-nw"
           href="https://desktop.github.com"
           aria-label="Open this file in GitHub Desktop"
           data-ga-click="Repository, open with desktop, type:windows">
            <svg class="octicon octicon-device-desktop" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M15 2H1c-.55 0-1 .45-1 1v9c0 .55.45 1 1 1h5.34c-.25.61-.86 1.39-2.34 2h8c-1.48-.61-2.09-1.39-2.34-2H15c.55 0 1-.45 1-1V3c0-.55-.45-1-1-1zm0 9H1V3h14v8z"/></svg>
        </a>

        <button type="button" class="btn-octicon disabled tooltipped tooltipped-nw"
          aria-label="You must be signed in to make or propose changes">
          <svg class="octicon octicon-pencil" viewBox="0 0 14 16" version="1.1" width="14" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M0 12v3h3l8-8-3-3-8 8zm3 2H1v-2h1v1h1v1zm10.3-9.3L12 6 9 3l1.3-1.3a.996.996 0 0 1 1.41 0l1.59 1.59c.39.39.39 1.02 0 1.41z"/></svg>
        </button>
        <button type="button" class="btn-octicon btn-octicon-danger disabled tooltipped tooltipped-nw"
          aria-label="You must be signed in to make or propose changes">
          <svg class="octicon octicon-trashcan" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M11 2H9c0-.55-.45-1-1-1H5c-.55 0-1 .45-1 1H2c-.55 0-1 .45-1 1v1c0 .55.45 1 1 1v9c0 .55.45 1 1 1h7c.55 0 1-.45 1-1V5c.55 0 1-.45 1-1V3c0-.55-.45-1-1-1zm-1 12H3V5h1v8h1V5h1v8h1V5h1v8h1V5h1v9zm1-10H2V3h9v1z"/></svg>
        </button>
  </div>

  <div class="file-info">
      36 lines (29 sloc)
      <span class="file-info-divider"></span>
    690 Bytes
  </div>
</div>

    

  <div itemprop="text" class="blob-wrapper data type-c">
      <table class="highlight tab-size js-file-line-container" data-tab-size="8">
      <tr>
        <td id="L1" class="blob-num js-line-number" data-line-number="1"></td>
        <td id="LC1" class="blob-code blob-code-inner js-file-line"><span class="pl-k">using</span> <span class="pl-en">System</span>;</td>
      </tr>
      <tr>
        <td id="L2" class="blob-num js-line-number" data-line-number="2"></td>
        <td id="LC2" class="blob-code blob-code-inner js-file-line"><span class="pl-k">using</span> <span class="pl-en">System</span>.<span class="pl-en">IO</span>;</td>
      </tr>
      <tr>
        <td id="L3" class="blob-num js-line-number" data-line-number="3"></td>
        <td id="LC3" class="blob-code blob-code-inner js-file-line"><span class="pl-k">using</span> <span class="pl-en">System</span>.<span class="pl-en">Threading</span>;</td>
      </tr>
      <tr>
        <td id="L4" class="blob-num js-line-number" data-line-number="4"></td>
        <td id="LC4" class="blob-code blob-code-inner js-file-line"><span class="pl-k">using</span> <span class="pl-en">System</span>.<span class="pl-en">Threading</span>.<span class="pl-en">Tasks</span>;</td>
      </tr>
      <tr>
        <td id="L5" class="blob-num js-line-number" data-line-number="5"></td>
        <td id="LC5" class="blob-code blob-code-inner js-file-line"><span class="pl-k">using</span> <span class="pl-en">Unosquare</span>.<span class="pl-en">RaspberryIO</span>.<span class="pl-en">Gpio</span>;</td>
      </tr>
      <tr>
        <td id="L6" class="blob-num js-line-number" data-line-number="6"></td>
        <td id="LC6" class="blob-code blob-code-inner js-file-line"><span class="pl-k">using</span> <span class="pl-k">static</span> <span class="pl-k">Unosquare</span>.<span class="pl-k">RaspberryIO</span>.<span class="pl-en">Pi</span>;</td>
      </tr>
      <tr>
        <td id="L7" class="blob-num js-line-number" data-line-number="7"></td>
        <td id="LC7" class="blob-code blob-code-inner js-file-line"><span class="pl-k">using</span> <span class="pl-en">Unosquare</span>.<span class="pl-en">RaspberryIO</span>.<span class="pl-en">Native</span>;</td>
      </tr>
      <tr>
        <td id="L8" class="blob-num js-line-number" data-line-number="8"></td>
        <td id="LC8" class="blob-code blob-code-inner js-file-line">
</td>
      </tr>
      <tr>
        <td id="L9" class="blob-num js-line-number" data-line-number="9"></td>
        <td id="LC9" class="blob-code blob-code-inner js-file-line"><span class="pl-k">namespace</span> <span class="pl-en">Components</span></td>
      </tr>
      <tr>
        <td id="L10" class="blob-num js-line-number" data-line-number="10"></td>
        <td id="LC10" class="blob-code blob-code-inner js-file-line">{</td>
      </tr>
      <tr>
        <td id="L11" class="blob-num js-line-number" data-line-number="11"></td>
        <td id="LC11" class="blob-code blob-code-inner js-file-line">
</td>
      </tr>
      <tr>
        <td id="L12" class="blob-num js-line-number" data-line-number="12"></td>
        <td id="LC12" class="blob-code blob-code-inner js-file-line">    <span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">Relay</span></td>
      </tr>
      <tr>
        <td id="L13" class="blob-num js-line-number" data-line-number="13"></td>
        <td id="LC13" class="blob-code blob-code-inner js-file-line">    {</td>
      </tr>
      <tr>
        <td id="L14" class="blob-num js-line-number" data-line-number="14"></td>
        <td id="LC14" class="blob-code blob-code-inner js-file-line">        <span class="pl-k">private</span> <span class="pl-en">GpioPin</span> <span class="pl-smi">gpioPin</span>;</td>
      </tr>
      <tr>
        <td id="L15" class="blob-num js-line-number" data-line-number="15"></td>
        <td id="LC15" class="blob-code blob-code-inner js-file-line">        <span class="pl-k">private</span> <span class="pl-k">ulong</span> <span class="pl-smi">last_interrupt_time</span>;</td>
      </tr>
      <tr>
        <td id="L16" class="blob-num js-line-number" data-line-number="16"></td>
        <td id="LC16" class="blob-code blob-code-inner js-file-line">
</td>
      </tr>
      <tr>
        <td id="L17" class="blob-num js-line-number" data-line-number="17"></td>
        <td id="LC17" class="blob-code blob-code-inner js-file-line">        <span class="pl-k">public</span> <span class="pl-en">Relay</span>(<span class="pl-en">GpioPin</span> <span class="pl-smi">gpioPin</span>)</td>
      </tr>
      <tr>
        <td id="L18" class="blob-num js-line-number" data-line-number="18"></td>
        <td id="LC18" class="blob-code blob-code-inner js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L19" class="blob-num js-line-number" data-line-number="19"></td>
        <td id="LC19" class="blob-code blob-code-inner js-file-line">            <span class="pl-k">this</span>.<span class="pl-smi">gpioPin</span> <span class="pl-k">=</span> <span class="pl-smi">gpioPin</span>;</td>
      </tr>
      <tr>
        <td id="L20" class="blob-num js-line-number" data-line-number="20"></td>
        <td id="LC20" class="blob-code blob-code-inner js-file-line">
</td>
      </tr>
      <tr>
        <td id="L21" class="blob-num js-line-number" data-line-number="21"></td>
        <td id="LC21" class="blob-code blob-code-inner js-file-line">            <span class="pl-en">Initialize</span>();</td>
      </tr>
      <tr>
        <td id="L22" class="blob-num js-line-number" data-line-number="22"></td>
        <td id="LC22" class="blob-code blob-code-inner js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L23" class="blob-num js-line-number" data-line-number="23"></td>
        <td id="LC23" class="blob-code blob-code-inner js-file-line">
</td>
      </tr>
      <tr>
        <td id="L24" class="blob-num js-line-number" data-line-number="24"></td>
        <td id="LC24" class="blob-code blob-code-inner js-file-line">        <span class="pl-k">private</span> <span class="pl-k">void</span> <span class="pl-en">Initialize</span>()</td>
      </tr>
      <tr>
        <td id="L25" class="blob-num js-line-number" data-line-number="25"></td>
        <td id="LC25" class="blob-code blob-code-inner js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L26" class="blob-num js-line-number" data-line-number="26"></td>
        <td id="LC26" class="blob-code blob-code-inner js-file-line">            <span class="pl-smi">gpioPin</span>.<span class="pl-smi">PinMode</span> <span class="pl-k">=</span> <span class="pl-smi">GpioPinDriveMode</span>.<span class="pl-smi">Output</span>;</td>
      </tr>
      <tr>
        <td id="L27" class="blob-num js-line-number" data-line-number="27"></td>
        <td id="LC27" class="blob-code blob-code-inner js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L28" class="blob-num js-line-number" data-line-number="28"></td>
        <td id="LC28" class="blob-code blob-code-inner js-file-line">
</td>
      </tr>
      <tr>
        <td id="L29" class="blob-num js-line-number" data-line-number="29"></td>
        <td id="LC29" class="blob-code blob-code-inner js-file-line">        <span class="pl-k">public</span> <span class="pl-k">bool</span> <span class="pl-smi">State</span></td>
      </tr>
      <tr>
        <td id="L30" class="blob-num js-line-number" data-line-number="30"></td>
        <td id="LC30" class="blob-code blob-code-inner js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L31" class="blob-num js-line-number" data-line-number="31"></td>
        <td id="LC31" class="blob-code blob-code-inner js-file-line">            <span class="pl-k">get</span> <span class="pl-k">=&gt;</span> <span class="pl-smi">gpioPin</span>.<span class="pl-en">Read</span>();</td>
      </tr>
      <tr>
        <td id="L32" class="blob-num js-line-number" data-line-number="32"></td>
        <td id="LC32" class="blob-code blob-code-inner js-file-line">            <span class="pl-k">set</span> <span class="pl-k">=&gt;</span> <span class="pl-smi">gpioPin</span>.<span class="pl-en">Write</span>(<span class="pl-smi">value</span>);</td>
      </tr>
      <tr>
        <td id="L33" class="blob-num js-line-number" data-line-number="33"></td>
        <td id="LC33" class="blob-code blob-code-inner js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L34" class="blob-num js-line-number" data-line-number="34"></td>
        <td id="LC34" class="blob-code blob-code-inner js-file-line">    }</td>
      </tr>
      <tr>
        <td id="L35" class="blob-num js-line-number" data-line-number="35"></td>
        <td id="LC35" class="blob-code blob-code-inner js-file-line">}</td>
      </tr>
</table>

  <details class="details-reset details-overlay BlobToolbar position-absolute js-file-line-actions dropdown d-none" aria-hidden="true">
    <summary class="btn-octicon ml-0 px-2 p-0 bg-white border border-gray-dark rounded-1" aria-label="Inline file action toolbar">
      <svg class="octicon octicon-kebab-horizontal" viewBox="0 0 13 16" version="1.1" width="13" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M1.5 9a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3zm5 0a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3zM13 7.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0z"/></svg>
    </summary>
    <details-menu>
      <ul class="BlobToolbar-dropdown dropdown-menu dropdown-menu-se mt-2">
        <li><clipboard-copy role="menuitem" class="dropdown-item" id="js-copy-lines" style="cursor:pointer;" data-original-text="Copy lines">Copy lines</clipboard-copy></li>
        <li><clipboard-copy role="menuitem" class="dropdown-item" id="js-copy-permalink" style="cursor:pointer;" data-original-text="Copy permalink">Copy permalink</clipboard-copy></li>
        <li><a class="dropdown-item js-update-url-with-hash" id="js-view-git-blame" role="menuitem" href="/robertsundstrom/IotCamera/blame/3a81c5527791fc081a13b71955903aaeca75433e/src/Components/Relay.cs">View git blame</a></li>
          <li><a class="dropdown-item" id="js-new-issue" role="menuitem" href="/robertsundstrom/IotCamera/issues/new">Open new issue</a></li>
      </ul>
    </details-menu>
  </details>

  </div>

  </div>

  <details class="details-reset details-overlay details-overlay-dark">
    <summary data-hotkey="l" aria-label="Jump to line"></summary>
    <details-dialog class="Box Box--overlay d-flex flex-column anim-fade-in fast linejump" aria-label="Jump to line">
      <!-- '"` --><!-- </textarea></xmp> --></option></form><form class="js-jump-to-line-form Box-body d-flex" action="" accept-charset="UTF-8" method="get"><input name="utf8" type="hidden" value="&#x2713;" />
        <input class="form-control flex-auto mr-3 linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" aria-label="Jump to line" autofocus>
        <button type="submit" class="btn" data-close-dialog>Go</button>
</form>    </details-dialog>
  </details>


  </div>
  <div class="modal-backdrop js-touch-events"></div>
</div>

    </div>
  </div>

  </div>

        
<div class="footer container-lg px-3" role="contentinfo">
  <div class="position-relative d-flex flex-justify-between pt-6 pb-2 mt-6 f6 text-gray border-top border-gray-light ">
    <ul class="list-style-none d-flex flex-wrap ">
      <li class="mr-3">&copy; 2018 <span title="0.20562s from unicorn-3218182479-3hc82">GitHub</span>, Inc.</li>
        <li class="mr-3"><a data-ga-click="Footer, go to terms, text:terms" href="https://github.com/site/terms">Terms</a></li>
        <li class="mr-3"><a data-ga-click="Footer, go to privacy, text:privacy" href="https://github.com/site/privacy">Privacy</a></li>
        <li class="mr-3"><a href="https://help.github.com/articles/github-security/" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li class="mr-3"><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
        <li><a data-ga-click="Footer, go to help, text:help" href="https://help.github.com">Help</a></li>
    </ul>

    <a aria-label="Homepage" title="GitHub" class="footer-octicon mr-lg-4" href="https://github.com">
      <svg height="24" class="octicon octicon-mark-github" viewBox="0 0 16 16" version="1.1" width="24" aria-hidden="true"><path fill-rule="evenodd" d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0 0 16 8c0-4.42-3.58-8-8-8z"/></svg>
</a>
   <ul class="list-style-none d-flex flex-wrap ">
        <li class="mr-3"><a data-ga-click="Footer, go to contact, text:contact" href="https://github.com/contact">Contact GitHub</a></li>
        <li class="mr-3"><a href="https://github.com/pricing" data-ga-click="Footer, go to Pricing, text:Pricing">Pricing</a></li>
      <li class="mr-3"><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li class="mr-3"><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
        <li class="mr-3"><a href="https://blog.github.com" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a data-ga-click="Footer, go to about, text:about" href="https://github.com/about">About</a></li>

    </ul>
  </div>
  <div class="d-flex flex-justify-center pb-6">
    <span class="f6 text-gray-light"></span>
  </div>
</div>



  <div id="ajax-error-message" class="ajax-error-message flash flash-error">
    <svg class="octicon octicon-alert" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M8.893 1.5c-.183-.31-.52-.5-.887-.5s-.703.19-.886.5L.138 13.499a.98.98 0 0 0 0 1.001c.193.31.53.501.886.501h13.964c.367 0 .704-.19.877-.5a1.03 1.03 0 0 0 .01-1.002L8.893 1.5zm.133 11.497H6.987v-2.003h2.039v2.003zm0-3.004H6.987V5.987h2.039v4.006z"/></svg>
    <button type="button" class="flash-close js-ajax-error-dismiss" aria-label="Dismiss error">
      <svg class="octicon octicon-x" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48L7.48 8z"/></svg>
    </button>
    You can’t perform that action at this time.
  </div>


    
    <script crossorigin="anonymous" integrity="sha512-Bb0Wovr1o2Cb3KlmHRGIjQlsUxTAa1LYyxdQ/tsndUC+t7gAyu/2fpdLW7eex9HXv13smytm3gzMD5+Z81gb9A==" type="application/javascript" src="https://assets-cdn.github.com/assets/frameworks-2b155dd967d6dd0a278d1a91dcafbeec.js"></script>
    
    <script crossorigin="anonymous" async="async" integrity="sha512-soY5O2nCbV0xNIEc+My3l94IG4krny2mZWWbhe4y2iuqN8oP+vJ/tIcY0dkcjnpmxViXvdqrkajw+JbG2aJwIQ==" type="application/javascript" src="https://assets-cdn.github.com/assets/github-c9e6dc85be45ffe1418c18262385d460.js"></script>
    
    
    
  <div class="js-stale-session-flash stale-session-flash flash flash-warn flash-banner d-none">
    <svg class="octicon octicon-alert" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M8.893 1.5c-.183-.31-.52-.5-.887-.5s-.703.19-.886.5L.138 13.499a.98.98 0 0 0 0 1.001c.193.31.53.501.886.501h13.964c.367 0 .704-.19.877-.5a1.03 1.03 0 0 0 .01-1.002L8.893 1.5zm.133 11.497H6.987v-2.003h2.039v2.003zm0-3.004H6.987V5.987h2.039v4.006z"/></svg>
    <span class="signed-in-tab-flash">You signed in with another tab or window. <a href="">Reload</a> to refresh your session.</span>
    <span class="signed-out-tab-flash">You signed out in another tab or window. <a href="">Reload</a> to refresh your session.</span>
  </div>
  <div class="facebox" id="facebox" style="display:none;">
  <div class="facebox-popup">
    <div class="facebox-content" role="dialog" aria-labelledby="facebox-header" aria-describedby="facebox-description">
    </div>
    <button type="button" class="facebox-close js-facebox-close" aria-label="Close modal">
      <svg class="octicon octicon-x" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48L7.48 8z"/></svg>
    </button>
  </div>
</div>

  <template id="site-details-dialog">
  <details class="details-reset details-overlay details-overlay-dark lh-default text-gray-dark" open>
    <summary aria-haspopup="dialog" aria-label="Close dialog"></summary>
    <details-dialog class="Box Box--overlay d-flex flex-column anim-fade-in fast">
      <button class="Box-btn-octicon m-0 btn-octicon position-absolute right-0 top-0" type="button" aria-label="Close dialog" data-close-dialog>
        <svg class="octicon octicon-x" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48L7.48 8z"/></svg>
      </button>
      <div class="octocat-spinner my-6 js-details-dialog-spinner"></div>
    </details-dialog>
  </details>
</template>

  <div class="Popover js-hovercard-content position-absolute" style="display: none; outline: none;" tabindex="0">
  <div class="Popover-message Popover-message--bottom-left Popover-message--large Box box-shadow-large" style="width:360px;">
  </div>
</div>

<div id="hovercard-aria-description" class="sr-only">
  Press h to open a hovercard with more details.
</div>


  </body>
</html>

