
     # <$ tag="powershell,Credential,PS,SecureStore" description="Powershell script to create a Credential for SecureStore access" $$
	 
	Create-DirectoryServiceCredential -topologyFile $topologyFile -environment $dirSvcEnvironment `
            -credentialName "keyname" `
            -credential "dummyNotNeeded" `
            -credentialGroup "DEFAULT"

	# $>