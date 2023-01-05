






Namespace AgentObjects
    Interface IAgentCtlCharacter

        Property Width As Integer

        Property Height As Integer

        Sub MoveTo(leftpos As Long, toppos As Long)

        Sub Show()

        Sub Hide()

        Sub Speak(text As String)

    End Interface

    Class Agent

    End Class
End Namespace
