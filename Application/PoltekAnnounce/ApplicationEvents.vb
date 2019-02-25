Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(ByVal sender As Object,
            ByVal e As ApplicationServices.StartupEventArgs
        ) Handles Me.Startup
            For Each s As String In My.Application.CommandLineArgs
                Select Case s.ToLower
                    Case "-start-viewer"
                        e.Cancel = True
                        With Launcher
                            .Show()
                            .StartUpArgument = True
                            .ExecutionButton.PerformClick()
                            If .StartUpError = True Then
                                Environment.Exit(0)
                            End If
                        End With
                        e.Cancel = False
                    Case "-start"
                        e.Cancel = True
                        Launcher.Show()
                        e.Cancel = False
                End Select
            Next
        End Sub
    End Class
End Namespace
