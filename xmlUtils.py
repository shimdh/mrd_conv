# -*- coding: utf-8 -*-
from xml.dom.minidom import Document


class XmlWriter:
    def __init__(self):
        self.doc = Document()

    def createNode(self, nodeName, parentNode='', withAttribute={}):
        node = self.doc.createElement(nodeName)
        if parentNode == '':
            createdNode = self.doc.appendChild(node)
        else:
            createdNode = parentNode.appendChild(node)

        if withAttribute != {}:
            for key, value in withAttribute.items():
                self.setAttribute(createdNode, key, value)
        return createdNode

    def setAttribute(self, node, key, value):
        node.setAttribute(key, value)

    def printXML(self):
        print self.doc.toprettyxml(indent="  ")
