import xml.etree.ElementTree as ET
import xmlrpc.client

url = 'http://localhost:8069/xmlrpc/'
DB='net'
USER='gbonanno@uoc.edu'
PASS='admin'

common_proxy = xmlrpc.client.ServerProxy(url+'common')
object = xmlrpc.client.ServerProxy(url+'object')
uid = common_proxy.login(DB,USER, PASS)

#Autentificacion
#uid = common.authenticate(DB,USER, PASS, {})

if uid:
    archivo_xml = ET.parse('/Flota/python/conductores.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_conductor','create',[{
            'x_idConductor':subraiz[0].text,
            'x_nombre':subraiz[1].text,
            'x_apellido':subraiz[2].text,
            'x_domicilio':subraiz[3].text,
            'x_permiso':subraiz[4].text,
            'x_disponibilidad':subraiz[5].text,
            }])
    print('Conductores Cargados correctamente')
else:
    print('Error al conectar a Odoo')