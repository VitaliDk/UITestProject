Feature: IdentityProvider
     Testing the identity provider

@mytag
Scenario: A user is able to log in to the DMI
	Given the user is on the login page
	When the user attempts to log in
	Then the user is redirected to the DMI

Scenario: A user is able to log out of the DMI
    Given the user is logged into the DMI
	# When the user attempts to log out
	# Then the user is redirected to the DMI login page
