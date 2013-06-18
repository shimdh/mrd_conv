# -*- coding: utf-8 -*-

import codecs
import os
from xlrd import open_workbook
from xmlUtils import XmlWriter


statusKeys = []
statusKeysKorean = []
ITEMS_NAMES = []
ITEMS_STATUS_LIST = []
STATUS_TAG = 'PlayerLevel'
SUB_PLURAL = 'PlayerLevel'
TAG_PLURAL = 's'
ITEMS_SETTINGS_FILE = SUB_PLURAL + TAG_PLURAL + 'Settings'
ITEMS_SETTINGS_XML_FILE = ITEMS_SETTINGS_FILE + '.xml'
ITEMS_SETTINGS_EXCEL_FILE = ITEMS_SETTINGS_FILE + '.xls'


wbPlayerLevels = open_workbook(os.getcwd() + "\\xls\\" + ITEMS_SETTINGS_EXCEL_FILE)
#wbEnemies = open_workbook('EnemiesSettings.xls')
#wbItems = open_workbook('ItemsSettings.xls')
# for s in wb.sheets():
#    # print 'Sheet:', s.name.encode('utf-8')
#    print 'Sheet:', s.name
#    for row in range(s.nrows):
#        values = []
#        for col in range(s.ncols):
#            if row == 0:
#                values.append(s.cell(row, col).value)
#                continue
#            else:
#                values.append(str(s.cell(row, col).value))
#        print ','.join(values)
#    print

for s in wbPlayerLevels.sheets():
    for row in range(s.nrows):
        values = []
        if row == 0:
            continue
        elif row == 1:
            for col in range(s.ncols):
                statusKeys.append(str(s.cell(row, col).value))
        else:
            for col in range(s.ncols):
                if col == 0:
                    ITEMS_NAMES.append(str(s.cell(row, col).value))
                values.append(str(s.cell(row, col).value))
            ITEMS_STATUS_LIST.append(values)

print statusKeys
print ITEMS_STATUS_LIST

doc = XmlWriter()
playerLevels_setting = doc.createNode(ITEMS_SETTINGS_FILE)

for index in range(len(ITEMS_STATUS_LIST)):
    level_value = doc.createNode(STATUS_TAG, playerLevels_setting)
    for key, value in zip(statusKeys, ITEMS_STATUS_LIST[index]):
        node_key = doc.createNode(key, level_value)
        node_value = doc.doc.createTextNode(value)
        node_key.appendChild(node_value)

# doc.printXML()


def createXmlFile(file_name):
    f = codecs.open(os.getcwd() + "\\xml\\" + file_name, 'w', 'utf-8')
    f.write(doc.doc.toprettyxml())
    f.close()

createXmlFile(ITEMS_SETTINGS_XML_FILE)
