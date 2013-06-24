# -*- coding: utf-8 -*-

import codecs
import os
from xlrd import open_workbook
from xmlUtils import XmlWriter


statusKeys = []
statusKeysKorean = []
ITEMS_NAMES = []
ITEMS_DESCRIPTION = []
ITEMS_STATUS_LIST = []
STATUS_TAG = 'DropItem'
SUB_PLURAL = 'DropItem'
TAG_PLURAL = 's'
ITEMS_SETTINGS_FILE = SUB_PLURAL + TAG_PLURAL + 'Settings'
ITEMS_SETTINGS_XML_FILE = ITEMS_SETTINGS_FILE
ITEMS_SETTINGS_EXCEL_FILE = ITEMS_SETTINGS_FILE + '.xls'


def createXmlFile(file_name):
    f = codecs.open(os.getcwd() + "\\xml\\" + file_name, 'w', 'utf-8')
    f.write(doc.doc.toprettyxml())
    f.close()


def float_eq(a, b, epsilon=0.00000001):
    return abs(a - b) < epsilon

wbItems = open_workbook(os.getcwd() + "\\xls\\" + ITEMS_SETTINGS_EXCEL_FILE)

for sheet_count in (0, 1, 2, 3, 4):
    s = wbItems.sheet_by_index(sheet_count)
    ITEMS_STATUS_LIST = []
    ITEMS_NAMES = []

    for row in range(s.nrows):
        values = []
        sum_rate = 0.0
        if row == 0:
            continue
        elif row == 1:
            for col in range(s.ncols):
                statusKeys.append(str(s.cell(row, col).value))
        else:
            for col in range(s.ncols):
                values.append(str(s.cell(row, col).value))

                if col == 0:
                    ITEMS_NAMES.append(str(s.cell(row, col).value))

                if col in (1, 3, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44):
                    rate_str = s.cell(row, col).value
                    if rate_str:
                        sum_rate += float(s.cell(row, col).value)
                # if col in (1, 7):
                #     values.append(unicode(s.cell(row, col).value))
                #     if col == 1:
                #         ITEMS_DESCRIPTION.append(unicode(s.cell(row, col).value))
                # else:
                #     if col == 0:
                #         ITEMS_NAMES.append(str(s.cell(row, col).value))
                #     values.append(str(s.cell(row, col).value))
            ITEMS_STATUS_LIST.append(values)
            if not float_eq(1.0, sum_rate):
                print (
                    "SUM Error:", sum_rate, "Index:", row, "Sheet No:", sheet_count)

    doc = XmlWriter()
    items_setting = doc.createNode(ITEMS_SETTINGS_FILE + s.name)

    for index in range(len(ITEMS_STATUS_LIST)):
        enemy_value = doc.createNode(STATUS_TAG + s.name, items_setting)
        for key, value in zip(statusKeys, ITEMS_STATUS_LIST[index]):
            node_key = doc.createNode(key, enemy_value)
            node_value = doc.doc.createTextNode(value)
            node_key.appendChild(node_value)
    createXmlFile(ITEMS_SETTINGS_XML_FILE + s.name + '.xml')

    print statusKeys
    print ITEMS_STATUS_LIST
