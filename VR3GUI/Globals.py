"""Holds global data and functions, this file will be created by the GUI"""
from decimal import Decimal, getcontext
#set the precision of Decimal numbers to 10 (should be at least double the number of digits that we are rounding to)
getcontext().prec = 10
from Enums import Direction, TrialType, CarBehaviour, FlowState, CarActionType, AvatarBehaviour, ParticipantInputType
import time
###
# GLOBAL VARIABLES
###
# ****************************************** '
# Using vizconnect_file:'viz_move_walking_VR.py'
# ****************************************** '
vizconnect_file='viz_move_walking_VR.py'
startingHotspotCenter = -1
startingHotspotDepth = 1
startingPosition = []
trackerurl = "PPT0@192.168.99.1"
headset_fov = 80  # diagonal fov = 60, so horizontal (by Pythagorean theorem) is 46.852 -- (now using oculus in steroscopic - Changed to 80
RADTODEG = 57.2957795
numTypesofCars = 15
randomize_car_spawn_order = False
roadWidth = 5.5
numOfLanes = 1
closeLaneCenterZ = roadWidth * 0.25
farLaneCenterZ = roadWidth * 0.75
timetoCross = 2.0
dataCollectionPeriod  =  0.01
nearMissDistance  =  1
criticalPoint = 1.375
hesitationVelThresh = 0.1
hesitationTimeThresh = 0.3
initialSpawnTime  =  23343
respawnStart  =  -200
respawnEnd  =  130
dataDirectoryPath = 'C:\\vr\\vr3\\_testing_data\\'
dataFileExtension  = ".txt"
currentTrial = None
initialFlowState = FlowState.FREERANGE
trial_intervention = 0
avgCarLength = 2.7
participantId  = ''
participantVariableNames = ['ParticipantId','ParticipantAge','ParticipantSex','ParticipantHeight']
participantVariableValues = ['','','','']
initialMainViewPosition = [0,1.82,-2.7]
fullCheckAngle  =  65
partialCheckAngle  =  45
max_check_angle = -113.0  # beyond this angle they can no longer see the road from the starting point
checkMaxAnglePitch  =  20
practiceTrialsMeanVelocity = 0
timeStamp = str(int(time.mktime(time.localtime())))
participantInputType = ParticipantInputType.HMD
trialInits = \
[\
(TrialType.PILOT, ffddd, CarBehaviour.SPAWNONSTARTTRIAL, [3,3,3], [], 50 , 50, 1, 1, True, 0, 0, AvatarBehaviour.NONE)
]
carsInits = \
[
]
practiceTrialsMeanCrossingTime = 0
practiceTrialsMeanCrossingTimeCount = 0
dumpedDataExtension = "_dumpedData.pkl"
participantDataExtension = "_participantData.pkl"
boundingBoxDataExtension = "_boundingBoxData.pkl"

